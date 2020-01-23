window.onload = function() {

    let dropdown = document.querySelector('li.dropdown');

    dropdown.onmouseover = function () {
        dropdown.classList.toggle('open');
    }

    dropdown.onmouseout = function () {
        dropdown.classList.toggle('open');
    }
};