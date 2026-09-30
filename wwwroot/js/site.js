document.addEventListener('DOMContentLoaded', function () {
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
