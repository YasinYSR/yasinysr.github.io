(() => {
  const reduce = matchMedia('(prefers-reduced-motion: reduce)').matches;
  const root = document.documentElement;
  const $ = (s, r = document) => r.querySelector(s);
  const css = (n) => getComputedStyle(root).getPropertyValue(n).trim();
  let A = css('--accent-rgb') || '91, 227, 166', B = css('--accent-2-rgb') || '91, 184, 255';
  addEventListener('tema', () => { A = css('--accent-rgb'); B = css('--accent-2-rgb'); });
  const el = (tag, cls, txt) => {
    const e = document.createElement(tag);
    if (cls) e.className = cls;
    if (txt != null) e.textContent = txt;
    return e;
  };
  const sayilar = (s) => s.split(',').map(Number);

  /* ---------- sekmeler ---------- */
  const sekmeler = [...document.querySelectorAll('.tab')];
  const paneller = [...document.querySelectorAll('.demo .panel')];
  let aktif = 0, gorunur = false;
  function sec(i, odak) {
    aktif = i;
    sekmeler.forEach((t, n) => {
      t.setAttribute('aria-selected', String(n === i));
      t.tabIndex = n === i ? 0 : -1;
      paneller[n].hidden = n !== i;
    });
    if (odak) sekmeler[i].focus();
    dispatchEvent(new Event('demosec'));
  }
  sekmeler.forEach((t, i) => {
    t.addEventListener('click', () => sec(i));
    t.addEventListener('keydown', (e) => {
      if (e.key === 'ArrowRight') { sec((i + 1) % sekmeler.length, true); e.preventDefault(); }
      else if (e.key === 'ArrowLeft') { sec((i + sekmeler.length - 1) % sekmeler.length, true); e.preventDefault(); }
    });
  });
  sekmeler.forEach((t, n) => { t.tabIndex = n === 0 ? 0 : -1; });
  new IntersectionObserver((k) => { gorunur = k[0].isIntersecting; }, { threshold: 0 }).observe($('#demo'));
  const calisir = () => gorunur && !document.hidden;

  function canvasKur(cv, boyutlandir) {
    const ctx = cv.getContext('2d');
    const o = { ctx, W: 0, H: 0 };
    o.ayarla = () => {
      const dpr = Math.min(devicePixelRatio || 1, 2);
      o.W = cv.clientWidth; o.H = cv.clientHeight;
      if (!o.W) return;
      cv.width = Math.round(o.W * dpr); cv.height = Math.round(o.H * dpr);
      ctx.setTransform(dpr, 0, 0, dpr, 0, 0);
      boyutlandir && boyutlandir(o.W, o.H);
    };
    addEventListener('resize', o.ayarla);
    addEventListener('demosec', o.ayarla);
    return o;
  }

  /* =====================================================================
     1) MANTIK ATOLYESI (elektronik_oyunu): kapilar ve 4 bit toplayici
     ===================================================================== */
  (() => {
    const kok = $('#p-logic');
    const a = { A: 0, B: 0 };
    const g = { a: [0, 0, 0, 0], b: [0, 0, 0, 0], cin: 0 }; // indeks 0 = en dusuk bit
    let mod = 'kapi', zamanlayici = null;

    const bar = el('div', 'lg-bar');
    const alan = el('div');
    const butonlar = {};
    [['kapi', 'Mantık kapıları'], ['topla', '4 bit toplayıcı']].forEach(([k, ad]) => {
      const b = el('button', k === mod ? 'on' : '', ad);
      b.type = 'button';
      b.addEventListener('click', () => { mod = k; Object.entries(butonlar).forEach(([n, x]) => x.classList.toggle('on', n === k)); ciz(); });
      butonlar[k] = b; bar.append(b);
    });
    kok.append(bar, alan);

    const anahtar = (etiket, deger, degistir) => {
      const b = el('button', 'sw' + (deger ? ' on' : ''), `${etiket}=${deger}`);
      b.type = 'button';
      b.setAttribute('aria-pressed', String(!!deger));
      b.addEventListener('click', degistir);
      return b;
    };

    const KAPILAR = [
      ['AND', (x, y) => x & y], ['OR', (x, y) => x | y], ['XOR', (x, y) => x ^ y],
      ['NAND', (x, y) => 1 - (x & y)], ['NOR', (x, y) => 1 - (x | y)], ['NOT A', (x) => 1 - x],
    ];

    function kapiCiz() {
      alan.textContent = '';
      const sw = el('div', 'sw-row');
      sw.append(el('span', '', 'Girişler'));
      for (const k of ['A', 'B']) sw.append(anahtar(k, a[k], () => { a[k] ^= 1; ciz(); }));
      const grid = el('div', 'gates-grid');
      for (const [ad, f] of KAPILAR) {
        const d = el('div', 'gate', ad);
        d.append(el('i', 'led' + (f(a.A, a.B) ? ' on' : '')));
        d.setAttribute('aria-label', `${ad} çıkışı ${f(a.A, a.B)}`);
        grid.append(d);
      }
      const tablo = el('table', 'tt');
      const bas = el('tr');
      ['A', 'B', 'AND', 'OR', 'XOR', 'NAND', 'NOR'].forEach((h) => bas.append(el('th', '', h)));
      tablo.append(bas);
      for (let i = 0; i < 4; i++) {
        const x = i >> 1, y = i & 1, tr = el('tr', x === a.A && y === a.B ? 'akt' : '');
        [x, y, x & y, x | y, x ^ y, 1 - (x & y), 1 - (x | y)].forEach((v) => tr.append(el('td', '', String(v))));
        tablo.append(tr);
      }
      alan.append(sw, grid, tablo);
    }

    const sayi = (arr) => arr.reduce((t, v, i) => t + (v << i), 0);
    function toplaCiz(goster) {
      alan.textContent = '';
      const satir = (ad, arr) => {
        const s = el('div', 'sw-row');
        s.append(el('span', '', ad));
        for (let i = 3; i >= 0; i--) s.append(anahtar(`${ad}${i}`, arr[i], () => { arr[i] ^= 1; yeniHesap(); }));
        return s;
      };
      const cin = el('div', 'sw-row');
      cin.append(el('span', '', 'Cin'), anahtar('Cin', g.cin, () => { g.cin ^= 1; yeniHesap(); }));
      alan.append(satir('A', g.a), satir('B', g.b), cin);

      // tam toplayici zinciri (kapi duzeyinde): s = a^b^c ; cout = ab | c(a^b)
      let c = g.cin;
      const asamalar = [];
      for (let i = 0; i < 4; i++) {
        const x = g.a[i], y = g.b[i];
        asamalar.push({ x, y, c, s: x ^ y ^ c, co: (x & y) | (c & (x ^ y)) });
        c = asamalar[i].co;
      }
      const satirFa = el('div', 'fa-row');
      for (let i = 3; i >= 0; i--) {
        const f = asamalar[i];
        const kutu = el('div', 'fa' + (i > goster ? ' sonra' : '') + (i === goster ? ' sonuc' : ''));
        kutu.append(el('h4', '', `BİT ${i}`));
        kutu.append(el('div', '', `${f.x} + ${f.y} + ${f.c}`));
        kutu.append(el('div', 's', String(f.s)));
        kutu.append(el('div', 'carry', `elde → ${f.co}`));
        satirFa.append(kutu);
      }
      const toplam = sayi(asamalar.map((f) => f.s)) + (asamalar[3].co << 4);
      const beklenen = sayi(g.a) + sayi(g.b) + g.cin;
      const sonuc = el('div', 'lg-sonuc');
      sonuc.innerHTML = '';
      const metin = `A=${sayi(g.a)} + B=${sayi(g.b)} + Cin=${g.cin} = `;
      const kalin = el('b', '', String(toplam));
      sonuc.append(metin, kalin, ` (${toplam.toString(2).padStart(5, '0')}₂)  ${toplam === beklenen ? '✓ tamsayı toplamıyla aynı' : '✗ hata'}`);
      alan.append(satirFa, sonuc);
    }
    function yeniHesap() {
      clearTimeout(zamanlayici);
      if (reduce) { toplaCiz(3); return; }
      let i = -1;
      const adim = () => { toplaCiz(i); if (i < 3) { i++; zamanlayici = setTimeout(adim, 140); } };
      adim();
    }
    function ciz() { clearTimeout(zamanlayici); mod === 'kapi' ? kapiCiz() : toplaCiz(3); }
    ciz();
  })();

  /* =====================================================================
     2) FIZIK SANDBOX (fizik_motoru): daireler, carpisma, yercekimi
     ===================================================================== */
  (() => {
    const cv = $('#fizikCv');
    const balls = [];
    let g = 900, e = .8, dur = reduce, bas = null, imlec = null;
    const sim = canvasKur(cv, (w, h) => {
      for (const b of balls) { b.x = Math.min(Math.max(b.x, b.r), w - b.r); b.y = Math.min(Math.max(b.y, b.r), h - b.r); }
    });
    sim.ayarla();

    function ekle(x, y, vx, vy) {
      const r = 10 + Math.random() * 12;
      balls.push({ x, y, vx, vy, r, m: r * r });
      if (balls.length > 90) balls.shift();
    }
    function baslangic() {
      balls.length = 0;
      for (let i = 0; i < 8; i++) ekle(60 + Math.random() * Math.max(80, (sim.W || 600) - 120), 40 + Math.random() * 120, (Math.random() - .5) * 300, 0);
    }
    baslangic();

    function adim(dt) {
      const n = 3, h = dt / n, W = sim.W, H = sim.H;
      for (let s = 0; s < n; s++) {
        for (const b of balls) {
          b.vy += g * h; b.x += b.vx * h; b.y += b.vy * h;
          if (b.x < b.r) { b.x = b.r; b.vx = Math.abs(b.vx) * e; }
          else if (b.x > W - b.r) { b.x = W - b.r; b.vx = -Math.abs(b.vx) * e; }
          if (b.y < b.r) { b.y = b.r; b.vy = Math.abs(b.vy) * e; }
          else if (b.y > H - b.r) {
            b.y = H - b.r; b.vy = -Math.abs(b.vy) * e; b.vx *= .995;
            if (Math.abs(b.vy) < 12) b.vy = 0;
          }
        }
        for (let i = 0; i < balls.length; i++) {
          const p = balls[i];
          for (let j = i + 1; j < balls.length; j++) {
            const q = balls[j], dx = q.x - p.x, dy = q.y - p.y, rr = p.r + q.r, d2 = dx * dx + dy * dy;
            if (d2 >= rr * rr || d2 === 0) continue;
            const d = Math.sqrt(d2), nx = dx / d, ny = dy / d, pen = rr - d, tot = p.m + q.m;
            p.x -= nx * pen * q.m / tot; p.y -= ny * pen * q.m / tot;
            q.x += nx * pen * p.m / tot; q.y += ny * pen * p.m / tot;
            const vn = (q.vx - p.vx) * nx + (q.vy - p.vy) * ny;
            if (vn < 0) {
              const j2 = -(1 + e) * vn / (1 / p.m + 1 / q.m);
              p.vx -= j2 * nx / p.m; p.vy -= j2 * ny / p.m;
              q.vx += j2 * nx / q.m; q.vy += j2 * ny / q.m;
            }
          }
        }
      }
    }

    function ciz() {
      const { ctx, W, H } = sim;
      ctx.clearRect(0, 0, W, H);
      const ca = sayilar(A), cb = sayilar(B);
      for (const b of balls) {
        const t = Math.min(Math.hypot(b.vx, b.vy) / 900, 1);
        const c = ca.map((v, i) => Math.round(v + (cb[i] - v) * t)).join(',');
        const gr = ctx.createRadialGradient(b.x - b.r * .3, b.y - b.r * .3, b.r * .1, b.x, b.y, b.r);
        gr.addColorStop(0, `rgba(255,255,255,.9)`); gr.addColorStop(.35, `rgba(${c},.95)`); gr.addColorStop(1, `rgba(${c},.55)`);
        ctx.fillStyle = gr;
        ctx.beginPath(); ctx.arc(b.x, b.y, b.r, 0, Math.PI * 2); ctx.fill();
      }
      if (bas && imlec) {
        ctx.strokeStyle = `rgba(${B}, .9)`; ctx.lineWidth = 2; ctx.setLineDash([6, 5]);
        ctx.beginPath(); ctx.moveTo(bas.x, bas.y); ctx.lineTo(imlec.x, imlec.y); ctx.stroke(); ctx.setLineDash([]);
        ctx.fillStyle = `rgba(${B}, .9)`; ctx.beginPath(); ctx.arc(bas.x, bas.y, 4, 0, Math.PI * 2); ctx.fill();
      }
    }

    const konum = (ev) => { const r = cv.getBoundingClientRect(); return { x: ev.clientX - r.left, y: ev.clientY - r.top }; };
    cv.addEventListener('pointerdown', (ev) => { bas = konum(ev); imlec = bas; cv.setPointerCapture(ev.pointerId); });
    cv.addEventListener('pointermove', (ev) => { if (bas) imlec = konum(ev); });
    const birak = (ev) => {
      if (!bas) return;
      const son = konum(ev), dx = son.x - bas.x, dy = son.y - bas.y;
      const hareket = Math.hypot(dx, dy) > 8;
      const lim = (v) => Math.max(-1400, Math.min(1400, v));
      ekle(bas.x, bas.y, hareket ? lim(dx * 6) : (Math.random() - .5) * 300, hareket ? lim(dy * 6) : 0);
      bas = imlec = null;
      if (dur) ciz();
    };
    cv.addEventListener('pointerup', birak);
    cv.addEventListener('pointercancel', () => { bas = imlec = null; });

    $('#fG').addEventListener('input', (ev) => { g = +ev.target.value; });
    $('#fE').addEventListener('input', (ev) => { e = +ev.target.value; });
    const durBtn = $('#fDur');
    const durYaz = () => { durBtn.textContent = dur ? 'Devam' : 'Duraklat'; durBtn.classList.toggle('on', dur); };
    durYaz();
    durBtn.addEventListener('click', () => { dur = !dur; durYaz(); if (dur) ciz(); });
    document.querySelector('[data-f="ekle"]').addEventListener('click', () => {
      for (let i = 0; i < 10; i++) ekle(30 + Math.random() * Math.max(40, sim.W - 60), 20 + Math.random() * 60, (Math.random() - .5) * 400, 0);
      if (dur) ciz();
    });
    document.querySelector('[data-f="temizle"]').addEventListener('click', () => { balls.length = 0; if (dur) ciz(); });

    const oku = $('#fOku');
    setInterval(() => {
      if (aktif !== 1) return;
      const ke = balls.reduce((t, b) => t + .5 * b.m * (b.vx * b.vx + b.vy * b.vy), 0);
      oku.textContent = `${balls.length} top · kinetik enerji ${Math.round(ke / 1000)}`;
    }, 250);

    let son = performance.now();
    (function dongu(simdi) {
      const dt = Math.min((simdi - son) / 1000, 1 / 30); son = simdi;
      if (aktif === 1 && calisir() && sim.W) {
        if (!dur) adim(dt);
        ciz();
      }
      requestAnimationFrame(dongu);
    })(son);
  })();

  /* =====================================================================
     3) EKG ATOLYESI (biyomedikal): ritim secimi, nabiz, AF
     ===================================================================== */
  (() => {
    const cv = $('#ekgCv');
    const PENCERE = 5; // saniye
    let buf = new Float32Array(0), t = 0, dur = reduce;
    let bpm = 72, af = false, ad = 'Normal sinüs ritmi';
    const beats = [];
    const sim = canvasKur(cv, (w) => {
      const yeni = new Float32Array(Math.ceil(w));
      yeni.set(buf.subarray(Math.max(0, buf.length - yeni.length)), Math.max(0, yeni.length - buf.length));
      buf = yeni;
    });
    sim.ayarla();

    const gauss = (x, mu, s, amp) => amp * Math.exp(-(((x - mu) / s) ** 2));
    // R tepesine gore saniye cinsinden P-QRS-T
    const dalga = (d) => (af ? 0 : gauss(d, -.17, .03, .13)) + gauss(d, -.035, .009, -.16) + gauss(d, 0, .0095, 1) + gauss(d, .035, .011, -.3) + gauss(d, .26, .055, .3);
    const rr = () => (af ? (60 / bpm) * (.55 + Math.random() * .9) : (60 / bpm) * (1 + (Math.random() - .5) * .04));
    function planla() {
      let son = beats.length ? beats[beats.length - 1] : t - .3;
      while (son < t + 1.2) { son += rr(); beats.push(son); }
    }
    function ornek(ts) {
      let y = 0;
      for (let i = beats.length - 1; i >= 0; i--) {
        const d = ts - beats[i];
        if (d > .6) break;
        if (d > -.3) y += dalga(d);
      }
      y += .012 * Math.sin(2 * Math.PI * .3 * ts) + (Math.random() - .5) * .008;
      if (af) y += .035 * Math.sin(2 * Math.PI * 7 * ts + Math.sin(ts * 3)) + .022 * Math.sin(2 * Math.PI * 5.3 * ts);
      return y;
    }

    let sonVurus = -1;
    const eBpm = $('#eBpm'), eRR = $('#eRR'), eDuz = $('#eDuz'), eAd = $('#eAd'), bpmKutu = $('.bpm');
    function oku() {
      const gecen = beats.filter((b) => b <= t);
      if (gecen.length < 3) return;
      const son = gecen.slice(-6), arali = [];
      for (let i = 1; i < son.length; i++) arali.push(son[i] - son[i - 1]);
      const ort = arali.reduce((a, b) => a + b, 0) / arali.length;
      const sap = Math.sqrt(arali.reduce((a, b) => a + (b - ort) ** 2, 0) / arali.length);
      eBpm.textContent = String(Math.round(60 / ort));
      eRR.textContent = `RR: ${Math.round(arali[arali.length - 1] * 1000)} ms`;
      eDuz.textContent = sap / ort > .12 ? 'Düzensiz ritim' : 'Düzenli ritim';
      const sonB = gecen[gecen.length - 1];
      if (sonB !== sonVurus) { sonVurus = sonB; bpmKutu.classList.remove('at'); void bpmKutu.offsetWidth; bpmKutu.classList.add('at'); }
    }

    function ciz() {
      const { ctx, W, H } = sim;
      if (!W) return;
      ctx.clearRect(0, 0, W, H);
      // EKG kagidi: kucuk ve buyuk kareler
      ctx.lineWidth = 1;
      for (let x = 0; x < W; x += 20) { ctx.strokeStyle = `rgba(${A}, ${x % 100 === 0 ? .16 : .06})`; ctx.beginPath(); ctx.moveTo(x + .5, 0); ctx.lineTo(x + .5, H); ctx.stroke(); }
      for (let y = 0; y < H; y += 20) { ctx.strokeStyle = `rgba(${A}, ${y % 100 === 0 ? .16 : .06})`; ctx.beginPath(); ctx.moveTo(0, y + .5); ctx.lineTo(W, y + .5); ctx.stroke(); }
      const taban = H * .62, genlik = H * .42;
      ctx.lineWidth = 2; ctx.lineJoin = 'round';
      ctx.shadowColor = `rgba(${A}, .9)`; ctx.shadowBlur = 8; ctx.strokeStyle = `rgba(${A}, .95)`;
      ctx.beginPath();
      for (let x = 0; x < buf.length; x++) { const y = taban - buf[x] * genlik; x ? ctx.lineTo(x, y) : ctx.moveTo(x, y); }
      ctx.stroke(); ctx.shadowBlur = 0;
      const u = buf.length - 1;
      ctx.fillStyle = '#fff'; ctx.beginPath(); ctx.arc(u, taban - buf[u] * genlik, 3.4, 0, Math.PI * 2); ctx.fill();
    }

    function hazirla(rit, hiz, yeniAf, yeniAd) {
      bpm = hiz; af = yeniAf; ad = yeniAd; eAd.textContent = ad;
      $('#eHiz').value = String(hiz);
      for (let i = beats.length - 1; i >= 0; i--) if (beats[i] > t + .25) beats.splice(i, 1);
      document.querySelectorAll('[data-r]').forEach((b) => b.classList.toggle('on', b.dataset.r === rit));
    }
    const RITIM = {
      normal: ['normal', 72, false, 'Normal sinüs ritmi'],
      tasi: ['tasi', 135, false, 'Sinüs taşikardisi'],
      brady: ['brady', 42, false, 'Sinüs bradikardisi'],
      af: ['af', 110, true, 'Atriyal fibrilasyon'],
    };
    document.querySelectorAll('[data-r]').forEach((b) => b.addEventListener('click', () => hazirla(...RITIM[b.dataset.r])));
    $('#eHiz').addEventListener('input', (ev) => { bpm = +ev.target.value; for (let i = beats.length - 1; i >= 0; i--) if (beats[i] > t + .25) beats.splice(i, 1); });
    const durBtn = $('#eDur');
    const durYaz = () => { durBtn.textContent = dur ? 'Devam' : 'Duraklat'; durBtn.classList.toggle('on', dur); };
    durYaz();
    durBtn.addEventListener('click', () => { dur = !dur; durYaz(); });

    // basta bos ekran olmasin: son 5 saniyeyi onceden doldur
    function onDoldur() {
      t = 0; beats.length = 0; beats.push(-PENCERE - 1);
      const px = buf.length || 600, dtp = PENCERE / px;
      for (let k = 0; k < px; k++) { t = -PENCERE + k * dtp; planla(); buf[k] = ornek(t); }
      t = 0; planla();
    }
    addEventListener('demosec', () => { if (!buf.some(Boolean) && sim.W) onDoldur(); });
    if (sim.W) onDoldur();

    let son = performance.now(), okuSayac = 0;
    (function dongu(simdi) {
      const dt = Math.min((simdi - son) / 1000, .05); son = simdi;
      if (aktif === 2 && calisir() && sim.W) {
        if (!dur && buf.length) {
          const pxs = buf.length / PENCERE, n = Math.max(1, Math.round(dt * pxs));
          buf.copyWithin(0, n);
          for (let k = 0; k < n; k++) { const ts = t + dt * ((k + 1) / n); planla(); buf[buf.length - n + k] = ornek(ts); }
          t += dt;
          while (beats.length && beats[0] < t - 8) beats.shift();
          okuSayac += dt;
          if (okuSayac > .15) { okuSayac = 0; oku(); }
        }
        ciz();
      }
      requestAnimationFrame(dongu);
    })(son);
  })();
})();
