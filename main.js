(() => {
  const reduce = matchMedia('(prefers-reduced-motion: reduce)').matches;
  const $ = (s) => document.querySelector(s);
  const root = document.documentElement;
  const durum = { fps: 0, dugum: 0 };

  /* ---------- tema ---------- */
  let A = '91, 227, 166', B = '91, 184, 255';
  const TEMALAR = {
    yesil: ['#5be3a6', '91, 227, 166', '#5bb8ff', '91, 184, 255'],
    mavi: ['#5bb8ff', '91, 184, 255', '#a78bfa', '167, 139, 250'],
    turuncu: ['#ffb454', '255, 180, 84', '#ff6b6b', '255, 107, 107'],
    pembe: ['#ff7ad9', '255, 122, 217', '#7ad7ff', '122, 215, 255'],
  };
  let tema = 'yesil';
  function temaUygula(ad, kaydet = true) {
    const t = TEMALAR[ad];
    if (!t) return false;
    tema = ad;
    root.style.setProperty('--accent', t[0]);
    root.style.setProperty('--accent-rgb', t[1]);
    root.style.setProperty('--accent-2', t[2]);
    root.style.setProperty('--accent-2-rgb', t[3]);
    A = t[1]; B = t[3];
    if (kaydet) { try { localStorage.setItem('tema', ad); } catch (e) { /* depolama kapali */ } }
    dispatchEvent(new Event('tema'));
    return true;
  }
  try { const k = localStorage.getItem('tema'); if (k) temaUygula(k, false); } catch (e) { /* yok say */ }

  /* ---------- kaydirma cubugu ---------- */
  const bar = $('#progress');
  const kaydirmaYuzde = () => {
    const max = root.scrollHeight - root.clientHeight;
    return max > 0 ? root.scrollTop / max : 0;
  };
  const onScroll = () => { bar.style.transform = `scaleX(${kaydirmaYuzde()})`; };
  addEventListener('scroll', onScroll, { passive: true });
  onScroll();

  /* ---------- imlec isigi ---------- */
  const glow = $('#glow');
  const fare = { x: -9999, y: -9999 };
  addEventListener('pointermove', (e) => {
    fare.x = e.clientX; fare.y = e.clientY;
    glow.style.transform = `translate(${e.clientX}px, ${e.clientY}px)`;
  }, { passive: true });
  addEventListener('pointerleave', () => { fare.x = fare.y = -9999; });

  /* ---------- canvas yardimcisi ---------- */
  function canvas(el, boyutlandir) {
    const ctx = el.getContext('2d');
    const ayarla = () => {
      const dpr = Math.min(devicePixelRatio || 1, 2);
      const w = el.clientWidth, h = el.clientHeight;
      el.width = Math.max(1, w * dpr); el.height = Math.max(1, h * dpr);
      ctx.setTransform(dpr, 0, 0, dpr, 0, 0);
      boyutlandir && boyutlandir(w, h);
    };
    return { ctx, ayarla };
  }

  /* ---------- sinir agi arka plani (nabizli, tiklayinca dalga) ---------- */
  (() => {
    const el = $('#net');
    let dugum = [], W = 0, H = 0;
    const nabiz = [], halka = [];
    const { ctx, ayarla } = canvas(el, (w, h) => {
      W = w; H = h;
      const n = Math.max(28, Math.min(95, Math.round((w * h) / 17000)));
      dugum = Array.from({ length: n }, () => {
        const vx = (Math.random() - .5) * .35, vy = (Math.random() - .5) * .35;
        return { x: Math.random() * w, y: Math.random() * h, vx, vy, bx: vx, by: vy };
      });
      durum.dugum = n;
    });
    ayarla();
    addEventListener('resize', () => { ayarla(); if (reduce) ciz(); });
    addEventListener('tema', () => { if (reduce) ciz(); });

    addEventListener('pointerdown', (e) => {
      if (e.target.closest('a, button, input, .term, #palette, #orb')) return;
      halka.push({ x: e.clientX, y: e.clientY, r: 0, omur: 1 });
      for (const d of dugum) {
        const dx = d.x - e.clientX, dy = d.y - e.clientY, m = Math.hypot(dx, dy);
        if (m < 220 && m > 0) { const k = (1 - m / 220) * 3.2; d.vx += (dx / m) * k; d.vy += (dy / m) * k; }
      }
    });

    const MESAFE = 140, FARE_MESAFE = 190;
    function ciz() {
      ctx.clearRect(0, 0, W, H);
      if (!reduce) {
        for (const d of dugum) {
          d.vx += (d.bx - d.vx) * .02; d.vy += (d.by - d.vy) * .02;
          d.x += d.vx; d.y += d.vy;
          if (d.x < 0 || d.x > W) d.vx *= -1;
          if (d.y < 0 || d.y > H) d.vy *= -1;
        }
        if (nabiz.length < 14 && Math.random() < .07) {
          const a = dugum[(Math.random() * dugum.length) | 0];
          const b = dugum.find((d) => d !== a && Math.hypot(a.x - d.x, a.y - d.y) < MESAFE);
          if (b) nabiz.push({ a, b, t: 0 });
        }
      }
      for (let i = 0; i < dugum.length; i++) {
        const a = dugum[i];
        for (let j = i + 1; j < dugum.length; j++) {
          const b = dugum[j];
          const d = Math.hypot(a.x - b.x, a.y - b.y);
          if (d < MESAFE) {
            ctx.strokeStyle = `rgba(${A}, ${(1 - d / MESAFE) * .22})`;
            ctx.lineWidth = 1;
            ctx.beginPath(); ctx.moveTo(a.x, a.y); ctx.lineTo(b.x, b.y); ctx.stroke();
          }
        }
        const fd = Math.hypot(a.x - fare.x, a.y - fare.y);
        if (fd < FARE_MESAFE) {
          ctx.strokeStyle = `rgba(${B}, ${(1 - fd / FARE_MESAFE) * .55})`;
          ctx.beginPath(); ctx.moveTo(a.x, a.y); ctx.lineTo(fare.x, fare.y); ctx.stroke();
        }
        ctx.fillStyle = `rgba(${A}, .65)`;
        ctx.beginPath(); ctx.arc(a.x, a.y, 1.8, 0, Math.PI * 2); ctx.fill();
      }
      for (let i = nabiz.length - 1; i >= 0; i--) {
        const p = nabiz[i];
        p.t += .03;
        if (p.t >= 1 || Math.hypot(p.a.x - p.b.x, p.a.y - p.b.y) > MESAFE) { nabiz.splice(i, 1); continue; }
        const x = p.a.x + (p.b.x - p.a.x) * p.t, y = p.a.y + (p.b.y - p.a.y) * p.t;
        ctx.shadowColor = `rgb(${A})`; ctx.shadowBlur = 12;
        ctx.fillStyle = '#fff';
        ctx.beginPath(); ctx.arc(x, y, 2.2, 0, Math.PI * 2); ctx.fill();
        ctx.shadowBlur = 0;
      }
      for (let i = halka.length - 1; i >= 0; i--) {
        const h = halka[i];
        h.r += 6; h.omur -= .018;
        if (h.omur <= 0) { halka.splice(i, 1); continue; }
        ctx.strokeStyle = `rgba(${B}, ${h.omur * .5})`; ctx.lineWidth = 2;
        ctx.beginPath(); ctx.arc(h.x, h.y, h.r, 0, Math.PI * 2); ctx.stroke();
      }
      if (!reduce) requestAnimationFrame(ciz);
    }
    ciz();
  })();

  /* ---------- WebGL dalga alani (GPU'da girisim deseni) ---------- */
  (() => {
    const el = $('#gl');
    if (!el) return;
    const gl = el.getContext('webgl', { antialias: false, alpha: false, powerPreference: 'low-power' });
    if (!gl) { el.remove(); return; }
    const vs = 'attribute vec2 p; void main(){ gl_Position = vec4(p, 0., 1.); }';
    const fs = [
      'precision mediump float;',
      'uniform vec2 r; uniform float t; uniform vec2 m; uniform vec3 c1; uniform vec3 c2;',
      'void main(){',
      '  vec2 uv = (gl_FragCoord.xy - .5 * r) / min(r.x, r.y);',
      '  float v = 0.;',
      '  for (int i = 0; i < 4; i++) {',
      '    float f = float(i);',
      '    vec2 p = vec2(cos(t * .13 + f * 1.7), sin(t * .11 + f * 2.3)) * vec2(.8, .5);',
      '    v += sin(length(uv - p) * 15. - t * .8 + f);',
      '  }',
      '  vec2 mm = (m * r - .5 * r) / min(r.x, r.y);',
      '  v += 1.4 * sin(length(uv - mm) * 20. - t * 1.8);',
      '  float fr = pow(1. - abs(sin(v * 1.1)), 10.);',
      '  vec3 col = mix(c1, c2, .5 + .5 * sin(v * .6 + t * .2));',
      '  float vig = smoothstep(1.6, .2, length(uv));',
      '  gl_FragColor = vec4(col * fr * .14 * vig, 1.);',
      '}',
    ].join('\n');
    const derle = (tip, kaynak) => {
      const s = gl.createShader(tip);
      gl.shaderSource(s, kaynak); gl.compileShader(s);
      return gl.getShaderParameter(s, gl.COMPILE_STATUS) ? s : null;
    };
    const v = derle(gl.VERTEX_SHADER, vs), f = derle(gl.FRAGMENT_SHADER, fs);
    const prog = gl.createProgram();
    if (!v || !f) { el.remove(); return; }
    gl.attachShader(prog, v); gl.attachShader(prog, f); gl.linkProgram(prog);
    if (!gl.getProgramParameter(prog, gl.LINK_STATUS)) { el.remove(); return; }
    gl.useProgram(prog);
    gl.bindBuffer(gl.ARRAY_BUFFER, gl.createBuffer());
    gl.bufferData(gl.ARRAY_BUFFER, new Float32Array([-1, -1, 1, -1, -1, 1, 1, 1]), gl.STATIC_DRAW);
    const loc = gl.getAttribLocation(prog, 'p');
    gl.enableVertexAttribArray(loc); gl.vertexAttribPointer(loc, 2, gl.FLOAT, false, 0, 0);
    const u = (ad) => gl.getUniformLocation(prog, ad);
    const uR = u('r'), uT = u('t'), uM = u('m'), uC1 = u('c1'), uC2 = u('c2');
    const rgb = (s) => s.split(',').map((x) => +x / 255);
    const renkler = () => { gl.uniform3fv(uC1, rgb(A)); gl.uniform3fv(uC2, rgb(B)); };
    let mx = .5, my = .5;
    const boyut = () => {
      el.width = Math.max(1, Math.round(el.clientWidth * .5));
      el.height = Math.max(1, Math.round(el.clientHeight * .5));
      gl.viewport(0, 0, el.width, el.height);
      gl.uniform2f(uR, el.width, el.height);
    };
    boyut(); renkler();
    addEventListener('resize', () => { boyut(); if (reduce) ciz(3); });
    addEventListener('tema', () => { renkler(); if (reduce) ciz(3); });
    function ciz(t) {
      if (fare.x >= 0) { mx += (fare.x / innerWidth - mx) * .08; my += ((1 - fare.y / innerHeight) - my) * .08; }
      gl.uniform1f(uT, t); gl.uniform2f(uM, mx, my);
      gl.drawArrays(gl.TRIANGLE_STRIP, 0, 4);
    }
    if (reduce) { ciz(3); return; }
    (function kare(ms) { ciz(ms / 1000); requestAnimationFrame(kare); })(performance.now());
  })();

  /* ---------- 3B sinir agi kuresi (surukle-dondur) ---------- */
  (() => {
    const el = $('#orb');
    if (!el) return;
    let W = 0, H = 0;
    const N = 150, P = [], E = [], nabiz = [];
    for (let i = 0; i < N; i++) {
      const y = 1 - (i / (N - 1)) * 2, r = Math.sqrt(1 - y * y), th = i * 2.399963;
      P.push([Math.cos(th) * r, y, Math.sin(th) * r]);
    }
    const var_ = new Set();
    for (let i = 0; i < N; i++) {
      const sirali = P.map((q, j) => [j, (P[i][0] - q[0]) ** 2 + (P[i][1] - q[1]) ** 2 + (P[i][2] - q[2]) ** 2])
        .filter(([j]) => j !== i).sort((a, b) => a[1] - b[1]).slice(0, 3);
      for (const [j] of sirali) {
        const k = i < j ? `${i}-${j}` : `${j}-${i}`;
        if (!var_.has(k)) { var_.add(k); E.push([i, j]); }
      }
    }
    let rotY = 0.6, rotX = .35, hiz = .004, surukle = false, sx = 0, sy = 0;
    const { ctx, ayarla } = canvas(el, (w, h) => { W = w; H = h; });
    ayarla();
    addEventListener('resize', () => { ayarla(); if (reduce) ciz(); });
    addEventListener('tema', () => { if (reduce) ciz(); });

    el.addEventListener('pointerdown', (e) => { surukle = true; sx = e.clientX; sy = e.clientY; el.setPointerCapture(e.pointerId); });
    el.addEventListener('pointermove', (e) => {
      if (!surukle) return;
      const dx = e.clientX - sx, dy = e.clientY - sy; sx = e.clientX; sy = e.clientY;
      rotY += dx * .008; rotX = Math.max(-1.2, Math.min(1.2, rotX + dy * .008)); hiz = dx * .0012;
    });
    const birak = () => { surukle = false; };
    el.addEventListener('pointerup', birak); el.addEventListener('pointercancel', birak);

    const donder = () => {
      const cy = Math.cos(rotY), sy_ = Math.sin(rotY), cx = Math.cos(rotX), sx_ = Math.sin(rotX);
      const R = Math.min(W, H) * .36, cx0 = W / 2, cy0 = H / 2;
      return P.map(([x, y, z]) => {
        const x1 = x * cy + z * sy_, z1 = -x * sy_ + z * cy;
        const y1 = y * cx - z1 * sx_, z2 = y * sx_ + z1 * cx;
        const f = 2.8 / (2.8 - z2);
        return { x: cx0 + x1 * R * f, y: cy0 + y1 * R * f, z: z2, f };
      });
    };
    function ciz() {
      ctx.clearRect(0, 0, W, H);
      if (!reduce) {
        if (!surukle) hiz += (.0035 - hiz) * .02;
        rotY += hiz;
        if (nabiz.length < 10 && Math.random() < .1) nabiz.push({ e: E[(Math.random() * E.length) | 0], t: 0 });
      }
      const Q = donder();
      const R = Math.min(W, H) * .36;
      ctx.lineWidth = 1;
      ctx.strokeStyle = `rgba(${A}, .1)`;
      ctx.beginPath(); ctx.ellipse(W / 2, H / 2, R * 1.18, R * 1.18 * Math.abs(Math.sin(rotX + .4)) + 2, 0, 0, Math.PI * 2); ctx.stroke();
      for (const [i, j] of E) {
        const a = Q[i], b = Q[j], d = (a.z + b.z) / 2 + 1;
        ctx.strokeStyle = `rgba(${A}, ${.05 + .32 * (d / 2)})`;
        ctx.beginPath(); ctx.moveTo(a.x, a.y); ctx.lineTo(b.x, b.y); ctx.stroke();
      }
      for (let i = 0; i < N; i++) {
        const q = Q[i], d = (q.z + 1) / 2, hub = i % 11 === 0;
        ctx.fillStyle = hub ? `rgba(${B}, ${.45 + .55 * d})` : `rgba(${A}, ${.3 + .7 * d})`;
        ctx.beginPath(); ctx.arc(q.x, q.y, (hub ? 2.6 : 1.3) + 1.6 * d, 0, Math.PI * 2); ctx.fill();
        if (hub && d > .45) {
          ctx.strokeStyle = `rgba(${B}, ${.35 * d})`;
          ctx.beginPath(); ctx.arc(q.x, q.y, 7 + 3 * d, 0, Math.PI * 2); ctx.stroke();
        }
      }
      for (let i = nabiz.length - 1; i >= 0; i--) {
        const p = nabiz[i];
        p.t += .025;
        if (p.t >= 1) { nabiz.splice(i, 1); continue; }
        const a = Q[p.e[0]], b = Q[p.e[1]];
        const x = a.x + (b.x - a.x) * p.t, y = a.y + (b.y - a.y) * p.t;
        ctx.shadowColor = `rgb(${A})`; ctx.shadowBlur = 14;
        ctx.fillStyle = '#fff';
        ctx.beginPath(); ctx.arc(x, y, 2.4, 0, Math.PI * 2); ctx.fill();
        ctx.shadowBlur = 0;
      }
      if (!reduce) requestAnimationFrame(ciz);
    }
    ciz();
  })();

  /* ---------- canli telemetri (hepsi tarayicidan okunan gercek degerler) ---------- */
  (() => {
    const yaz = (id, v) => { const e = document.getElementById(id); if (e && e.textContent !== v) e.textContent = v; };
    let kare = 0, son = performance.now();
    const t0 = son;
    const iki = (n) => String(n).padStart(2, '0');
    (function tik(simdi) {
      kare++;
      if (simdi - son >= 1000) {
        durum.fps = Math.round((kare * 1000) / (simdi - son)); kare = 0; son = simdi;
        yaz('hFps', String(durum.fps));
      }
      requestAnimationFrame(tik);
    })(son);
    const guncelle = () => {
      yaz('hNode', String(durum.dugum));
      yaz('hMouse', fare.x < 0 ? '--' : `${Math.round(fare.x)},${Math.round(fare.y)}`);
      yaz('hScroll', `${Math.round(kaydirmaYuzde() * 100)}%`);
      yaz('hClock', new Date().toLocaleTimeString('tr-TR'));
      const sn = Math.floor((performance.now() - t0) / 1000);
      yaz('hUp', `${iki(Math.floor(sn / 60))}:${iki(sn % 60)}`);
    };
    guncelle();
    setInterval(guncelle, 250);
  })();

  /* ---------- gorununce belir ---------- */
  const io = new IntersectionObserver((kayit) => {
    kayit.forEach((k) => { if (k.isIntersecting) { k.target.classList.add('in'); io.unobserve(k.target); } });
  }, { threshold: .12 });
  document.querySelectorAll('.reveal').forEach((el, i) => {
    el.style.transitionDelay = `${(i % 3) * 90}ms`;
    io.observe(el);
  });

  /* ---------- 3B egilen kartlar ---------- */
  if (!reduce && matchMedia('(hover: hover)').matches) {
    document.querySelectorAll('.project').forEach((kart) => {
      kart.addEventListener('pointermove', (e) => {
        const r = kart.getBoundingClientRect();
        const x = (e.clientX - r.left) / r.width, y = (e.clientY - r.top) / r.height;
        kart.style.setProperty('--ry', `${(x - .5) * 14}deg`);
        kart.style.setProperty('--rx', `${(.5 - y) * 14}deg`);
        kart.style.setProperty('--mx', `${x * 100}%`);
        kart.style.setProperty('--my', `${y * 100}%`);
      });
      kart.addEventListener('pointerleave', () => {
        kart.style.setProperty('--rx', '0deg'); kart.style.setProperty('--ry', '0deg');
      });
    });
  }

  /* ---------- isim "sifre cozme" efekti, yazan rol, sayac ---------- */
  function coz(el, metin, sure) {
    if (reduce) { el.textContent = metin; return; }
    const harf = '!<>-_\\/[]{}=+*^?#01ABCDEF';
    const t0 = performance.now();
    (function k(simdi) {
      const p = Math.min((simdi - t0) / sure, 1);
      let s = '';
      for (let i = 0; i < metin.length; i++) {
        s += i < metin.length * p ? metin[i] : harf[Math.floor(Math.random() * harf.length)];
      }
      el.textContent = s;
      if (p < 1) requestAnimationFrame(k);
    })(t0);
  }
  function heroBasla() {
    document.querySelectorAll('h1 .sc').forEach((el, i) => {
      const metin = el.textContent;
      setTimeout(() => coz(el, metin, 900), i * 250);
    });
    const typed = $('#typed');
    const roller = ['biyomedikal mühendisi', 'otomasyon geliştiricisi', 'gömülü sistem meraklısı', 'yapay zeka öğrencisi'];
    if (reduce) { typed.textContent = roller[0]; }
    else {
      let r = 0, c = 0, silme = false;
      const adim = () => {
        const kelime = roller[r];
        c += silme ? -1 : 1;
        typed.textContent = kelime.slice(0, c);
        let gecikme = silme ? 35 : 75;
        if (!silme && c === kelime.length) { silme = true; gecikme = 1500; }
        else if (silme && c === 0) { silme = false; r = (r + 1) % roller.length; gecikme = 350; }
        setTimeout(adim, gecikme);
      };
      adim();
    }
    document.querySelectorAll('[data-count]').forEach((el) => {
      const hedef = +el.dataset.count;
      if (reduce) return;
      const t0 = performance.now();
      const tik = (t) => {
        const p = Math.min((t - t0) / 1400, 1);
        el.textContent = Math.round(hedef * (1 - Math.pow(1 - p, 3)));
        if (p < 1) requestAnimationFrame(tik);
      };
      el.textContent = '0';
      requestAnimationFrame(tik);
    });
  }

  /* ---------- acilis (boot) ekrani ---------- */
  (function boot() {
    let atla = reduce;
    try { if (sessionStorage.getItem('boot')) atla = true; } catch (e) { /* yok say */ }
    if (atla) { heroBasla(); return; }
    const o = document.createElement('div');
    o.id = 'boot';
    o.innerHTML = '<pre></pre><div class="boot-hint">Geçmek için tıkla veya bir tuşa bas</div>';
    document.body.appendChild(o);
    document.body.style.overflow = 'hidden';
    const log = o.querySelector('pre');
    const satirlar = [
      'YY-OS v1.0 başlatılıyor...',
      '[ OK ] sinir ağı çekirdeği yüklendi',
      '[ OK ] EKG izleyici bağlandı',
      '[ OK ] 3B küre hazır',
      '[ OK ] dalga alanı (GPU) çalışıyor',
      '[ OK ] terminal dinlemede',
      '',
      'Hoş geldin.',
    ];
    let i = 0, bitti = false;
    const son = () => {
      if (bitti) return;
      bitti = true;
      try { sessionStorage.setItem('boot', '1'); } catch (e) { /* yok say */ }
      o.classList.add('gizle');
      document.body.style.overflow = '';
      removeEventListener('keydown', son);
      setTimeout(() => o.remove(), 600);
      heroBasla();
    };
    o.addEventListener('pointerdown', son);
    addEventListener('keydown', son);
    (function yaz() {
      if (bitti) return;
      if (i < satirlar.length) { log.textContent += satirlar[i++] + '\n'; setTimeout(yaz, 240); }
      else setTimeout(son, 450);
    })();
  })();

  /* ---------- komut paleti (Ctrl+K) ---------- */
  const git = (id) => {
    const e = document.getElementById(id);
    if (e) e.scrollIntoView({ behavior: reduce ? 'auto' : 'smooth' });
  };
  (() => {
    const oge = [
      { ad: 'Hakkımda', ip: 'bölüm', fn: () => git('about') },
      { ad: 'Projelerim', ip: 'bölüm', fn: () => git('projects') },
      { ad: 'Canlı demolar', ip: 'bölüm', fn: () => git('demo') },
      { ad: 'Terminal', ip: 'bölüm', fn: () => { git('terminal'); setTimeout(() => $('#termIn').focus({ preventScroll: true }), 500); } },
      { ad: 'İletişim', ip: 'bölüm', fn: () => git('contact') },
      { ad: 'GitHub profilini aç', ip: 'bağlantı', fn: () => open('https://github.com/YasinYSR', '_blank', 'noopener') },
      { ad: 'E-posta yaz', ip: 'bağlantı', fn: () => { location.href = 'mailto:bme.yasinysr@gmail.com'; } },
      ...Object.keys(TEMALAR).map((k) => ({ ad: `Tema: ${k}`, ip: 'renk', fn: () => temaUygula(k) })),
    ];
    const kap = document.createElement('div');
    kap.id = 'palette'; kap.hidden = true;
    kap.innerHTML = '<div class="pal-box" role="dialog" aria-modal="true" aria-label="Komut paleti">' +
      '<input type="text" placeholder="Ne yapmak istersin?" aria-label="Komut ara" autocomplete="off" spellcheck="false">' +
      '<ul></ul><div class="pal-foot">↑↓ seç · Enter çalıştır · Esc kapat</div></div>';
    document.body.appendChild(kap);
    const inp = kap.querySelector('input'), liste = kap.querySelector('ul');
    let sonuc = oge, idx = 0;
    const ciz = () => {
      liste.textContent = '';
      sonuc.forEach((o, n) => {
        const li = document.createElement('li');
        if (n === idx) li.className = 'sec';
        const ad = document.createElement('span'); ad.textContent = o.ad;
        const ip = document.createElement('small'); ip.textContent = o.ip;
        li.append(ad, ip);
        li.addEventListener('click', () => calistir(o));
        liste.appendChild(li);
      });
      if (!sonuc.length) { const li = document.createElement('li'); li.textContent = 'Sonuç yok'; liste.appendChild(li); }
    };
    const ac = () => { kap.hidden = false; inp.value = ''; sonuc = oge; idx = 0; ciz(); inp.focus(); };
    const kapat = () => { kap.hidden = true; };
    const calistir = (o) => { kapat(); o.fn(); };
    inp.addEventListener('input', () => {
      const q = inp.value.trim().toLocaleLowerCase('tr');
      sonuc = oge.filter((o) => o.ad.toLocaleLowerCase('tr').includes(q)); idx = 0; ciz();
    });
    inp.addEventListener('keydown', (e) => {
      if (e.key === 'ArrowDown') { idx = Math.min(idx + 1, sonuc.length - 1); ciz(); e.preventDefault(); }
      else if (e.key === 'ArrowUp') { idx = Math.max(idx - 1, 0); ciz(); e.preventDefault(); }
      else if (e.key === 'Enter' && sonuc[idx]) calistir(sonuc[idx]);
    });
    kap.addEventListener('pointerdown', (e) => { if (e.target === kap) kapat(); });
    addEventListener('keydown', (e) => {
      if ((e.ctrlKey || e.metaKey) && e.key.toLowerCase() === 'k') { e.preventDefault(); kap.hidden ? ac() : kapat(); }
      else if (e.key === 'Escape' && !kap.hidden) kapat();
    });
    $('#palBtn').addEventListener('click', ac);
  })();

  /* ---------- terminal ---------- */
  (() => {
    const out = $('#termOut'), inp = $('#termIn'), body = $('#termBody');
    const gecmis = []; let gi = 0;
    const komutlar = {
      help: () => 'Komutlar:\n  hakkimda    beni tanı\n  projeler    neler yapıyorum\n  iletisim    bana ulaş\n  github      GitHub profilim\n  neofetch    sistem bilgisi\n  demo        canlı demolara git\n  tema <ad>   renk değiştir (yesil, mavi, turuncu, pembe)\n  whoami      sen kimsin\n  temizle     ekranı temizle\n\nİpucu: Ctrl+K ile komut paletini aç.',
      hakkimda: () => 'Yasin YAŞAR, biyomedikal mühendisi.\nHastane ortamı için otomasyon, gömülü elektronik ve yapay zeka.\n"Daima bir adım geleceğe!"',
      projeler: () => '1. Bakım ve servis otomasyonu\n2. PCB arıza tespiti\n3. Programlayıcılar\n4. Yerel kodlayıcı\n5. Oyun ve simülasyon\n6. MAC bulucu',
      iletisim: () => 'E-posta : bme.yasinysr@gmail.com\nGitHub  : github.com/YasinYSR',
      github: () => { open('https://github.com/YasinYSR', '_blank', 'noopener'); return 'GitHub açılıyor...'; },
      whoami: () => 'misafir. Hoş geldin! :)',
      ls: () => 'hakkimda  projeler  iletisim',
      neofetch: () => [
        'yasin@portfolyo', '---------------',
        'OS        : yy-os (tarayıcıda çalışır)',
        'Meslek    : Biyomedikal Mühendisi',
        'Alan      : otomasyon · gömülü · yapay zeka',
        `Ekran     : ${innerWidth}x${innerHeight}`,
        `Dil       : ${navigator.language}`,
        `FPS       : ${durum.fps || '--'}`,
        `Tema      : ${tema}`,
      ].join('\n'),
      tema: (arg) => {
        if (!arg[0]) return `Temalar: ${Object.keys(TEMALAR).join(', ')}\nKullanım: tema mavi`;
        return temaUygula(arg[0].toLowerCase()) ? `Tema "${arg[0].toLowerCase()}" olarak ayarlandı.` : { hata: `Böyle bir tema yok. Seçenekler: ${Object.keys(TEMALAR).join(', ')}` };
      },
      demo: () => { git('demo'); return 'Canlı demolara gidiliyor: mantık atölyesi, fizik sandbox, EKG atölyesi.'; },
      sudo: () => ({ hata: 'Güzel deneme. Burada yetkili olan sadece Yasin.' }),
    };
    const yaz = (metin, sinif) => {
      const d = document.createElement('div');
      if (sinif) d.className = sinif;
      d.textContent = metin;
      out.appendChild(d);
      body.scrollTop = body.scrollHeight;
    };
    yaz('Hoş geldin! Başlamak için "help" yaz.', 'hl');
    inp.addEventListener('keydown', (e) => {
      if (e.key === 'ArrowUp') { if (gi > 0) inp.value = gecmis[--gi]; e.preventDefault(); return; }
      if (e.key === 'ArrowDown') {
        if (gi < gecmis.length - 1) inp.value = gecmis[++gi];
        else { gi = gecmis.length; inp.value = ''; }
        e.preventDefault(); return;
      }
      if (e.key !== 'Enter') return;
      const girdi = inp.value.trim(); inp.value = '';
      if (!girdi) return;
      gecmis.push(girdi); gi = gecmis.length;
      yaz(`yasin@portfolyo:~$ ${girdi}`, 'cmd');
      const [ad0, ...arg] = girdi.split(/\s+/);
      const ad = ad0.toLowerCase();
      if (ad === 'temizle' || ad === 'clear') { out.textContent = ''; return; }
      const fn = komutlar[ad];
      if (!fn) { yaz(`${ad}: komut bulunamadı. "help" yazmayı dene.`, 'err'); return; }
      const sonuc = fn(arg);
      sonuc && sonuc.hata ? yaz(sonuc.hata, 'err') : yaz(sonuc);
    });
    body.addEventListener('click', () => inp.focus({ preventScroll: true }));
  })();
})();
