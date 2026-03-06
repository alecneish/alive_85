document.addEventListener('DOMContentLoaded', function () {
  if (!sessionStorage.getItem('alive85_booted')) {
    document.body.classList.add('crt-boot');
    sessionStorage.setItem('alive85_booted', '1');
    document.body.addEventListener('animationend', function handler() {
      document.body.classList.remove('crt-boot');
      document.body.removeEventListener('animationend', handler);
    });
  }

  var starsEl = document.getElementById('stars');
  if (starsEl) {
    var colors = ['star--yellow', 'star--pink', 'star--cyan', 'star--white', 'star--white', 'star--white'];
    for (var i = 0; i < 70; i++) {
      var star = document.createElement('div');
      var colorClass = colors[Math.floor(Math.random() * colors.length)];
      var isLarge = Math.random() < 0.1;
      star.className = 'star ' + colorClass + (isLarge ? ' star--large' : '');
      star.style.left = Math.random() * 100 + '%';
      star.style.top = Math.random() * 55 + '%';
      star.style.animationDelay = Math.random() * 4 + 's';
      star.style.animationDuration = (Math.random() * 3 + 2) + 's';
      if (!isLarge) {
        var size = (Math.random() * 2 + 1) + 'px';
        star.style.width = size;
        star.style.height = size;
      }
      starsEl.appendChild(star);
    }
  }

  // Mobile hamburger nav
  var hamburger = document.getElementById('nav-hamburger');
  var overlay = document.getElementById('nav-mobile-overlay');
  if (hamburger && overlay) {
    hamburger.addEventListener('click', function () {
      hamburger.classList.toggle('open');
      overlay.classList.toggle('open');
      document.body.style.overflow = overlay.classList.contains('open') ? 'hidden' : '';
    });
    overlay.querySelectorAll('a').forEach(function (link) {
      link.addEventListener('click', function () {
        hamburger.classList.remove('open');
        overlay.classList.remove('open');
        document.body.style.overflow = '';
      });
    });
  }
});
