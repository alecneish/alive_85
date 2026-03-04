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
    for (var i = 0; i < 45; i++) {
      var pellet = document.createElement('div');
      pellet.className = 'star';
      pellet.style.left = Math.random() * 100 + '%';
      pellet.style.top = Math.random() * 55 + '%';
      pellet.style.animationDelay = Math.random() * 3 + 's';
      var size = (Math.random() * 3 + 2) + 'px';
      pellet.style.width = size;
      pellet.style.height = size;
      starsEl.appendChild(pellet);
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
