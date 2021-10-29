const inquirer = require('inquirer')

var colectNumeros = [
    {type: 'input', name:'num1', message: 'Primeiro numero: '}
    ,{type: 'input', name:'num2', message: 'Segundo numero: '}
]

function highNumero (colectNumeros) {

    return inquirer.prompt(colectNumeros).then(resposta => {
        if(resposta['num1'] == resposta ['num2']) {
            console.log('É um impate');
        }
        else {
            resposta['num1'] > resposta['num2'] ? console.log('Num 1 é maior') : console.log('Num 2 é maior');
        }      
        
    })
}

highNumero(colectNumeros);