window.addEventListener('load', function() {
    var app = document.getElementById('app');
    // app.innerHTML = 'Hello, World!';

    var themeToggleButton = document.createElement('button');
    themeToggleButton.textContent = 'Toggle Theme';
    app.appendChild(themeToggleButton);

    themeToggleButton.addEventListener('click', function() {
        document.body.classList.toggle('dark-theme');
        document.body.classList.toggle('light-theme');
    });

    var calculator = document.createElement('div');
    calculator.classList.add('calculator');
    calculator.innerHTML = `
        <input type="text" id="display" disabled>
        <div>
            <button>(</button>
            <button>)</button>
            <button>C</button>
            <button>/</button>
        </div>
        <div>
            <button>7</button>
            <button>8</button>
            <button>9</button>
            <button>*</button>
        </div>
        <div>
            <button>4</button>
            <button>5</button>
            <button>6</button>
            <button>-</button>
        </div>
        <div>
            <button>1</button>
            <button>2</button>
            <button>3</button>
            <button>+</button>
        </div>
        <div>
            <button>0</button>
            <button>.</button>
            <button>=</button>
        </div>
    `;
    app.appendChild(calculator);

    var display = document.getElementById('display');
    var buttons = calculator.querySelectorAll('button');
    var currentInput = '';

    buttons.forEach(function(button) {
        button.addEventListener('click', function() {
            var value = button.textContent;

            if (value === 'C') {
                currentInput = '';
                display.value = '';
            } else if (value === '=') {
                try {
                    currentInput = eval(currentInput);
                    display.value = currentInput;
                } catch (e) {
                    display.value = 'Error';
                }
            } else {
                currentInput += value;
                display.value = currentInput;
            }
        });
    });
});