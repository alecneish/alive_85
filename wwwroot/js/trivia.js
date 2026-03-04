(function () {
  var questions = window.triviaData || [];
  var currentIndex = 0;
  var score = 0;
  var streak = parseInt(localStorage.getItem('alive85_streak') || '0', 10);
  var answered = false;

  var questionEl = document.getElementById('trivia-question');
  var optionsEl = document.getElementById('trivia-options');
  var footerEl = document.getElementById('trivia-footer');
  var explanationEl = document.getElementById('trivia-explanation');

  if (!questionEl || questions.length === 0) return;

  function renderQuestion() {
    answered = false;
    var q = questions[currentIndex];
    questionEl.textContent = q.question;
    explanationEl.textContent = '';
    explanationEl.className = 'trivia-explanation';
    optionsEl.innerHTML = '';

    q.options.forEach(function (opt, i) {
      var btn = document.createElement('button');
      btn.className = 'trivia-btn';
      btn.textContent = opt;
      btn.addEventListener('click', function () { handleAnswer(i); });
      optionsEl.appendChild(btn);
    });

    footerEl.innerHTML = 'Question ' + (currentIndex + 1) + ' of ' + questions.length +
      ' &bull; Score: ' + score + '/' + questions.length +
      ' &bull; Streak: ' + streak + ' \uD83D\uDD25';
  }

  function handleAnswer(selectedIndex) {
    if (answered) return;
    answered = true;

    var q = questions[currentIndex];
    var buttons = optionsEl.querySelectorAll('.trivia-btn');

    buttons.forEach(function (btn, i) {
      btn.style.pointerEvents = 'none';
      if (i === q.correctIndex) {
        btn.classList.add('correct');
      } else if (i === selectedIndex) {
        btn.classList.add('wrong');
      }
    });

    if (selectedIndex === q.correctIndex) {
      score++;
      streak++;
      localStorage.setItem('alive85_streak', streak.toString());
    } else {
      streak = 0;
      localStorage.setItem('alive85_streak', '0');
    }

    explanationEl.textContent = q.explanation;
    explanationEl.className = 'trivia-explanation trivia-explanation-visible';

    footerEl.innerHTML = 'Question ' + (currentIndex + 1) + ' of ' + questions.length +
      ' &bull; Score: ' + score + '/' + questions.length +
      ' &bull; Streak: ' + streak + ' \uD83D\uDD25';

    setTimeout(function () {
      currentIndex++;
      if (currentIndex < questions.length) {
        renderQuestion();
      } else {
        showResults();
      }
    }, 2200);
  }

  function showResults() {
    questionEl.textContent = 'Round Complete!';
    optionsEl.innerHTML = '';
    explanationEl.textContent = '';
    explanationEl.className = 'trivia-explanation';

    var msg = document.createElement('div');
    msg.className = 'trivia-results';
    msg.innerHTML = '<div class="trivia-results-score">' + score + '/' + questions.length + '</div>' +
      '<div class="trivia-results-text">' + getResultText(score, questions.length) + '</div>' +
      '<button class="btn-secondary trivia-replay" onclick="location.reload()">Play Again</button>';
    optionsEl.appendChild(msg);

    footerEl.innerHTML = 'Streak: ' + streak + ' \uD83D\uDD25';
  }

  function getResultText(s, total) {
    if (s === total) return 'Perfect score! You ARE the 80s.';
    if (s >= total * 0.8) return 'Impressive! You know your decade.';
    if (s >= total * 0.6) return 'Not bad. Keep studying those VHS tapes.';
    if (s >= total * 0.4) return 'Room for improvement. Hit the arcade.';
    return 'Were you even born yet? Try again!';
  }

  renderQuestion();
})();
