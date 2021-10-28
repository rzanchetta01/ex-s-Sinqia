/*'use strict';
var nome;
var sobrenome;
var idade;
var sexo;*/

const inquirer = require('inquirer')

var _nome;
var _sobrenome;
var _sexo;
var _idade;

var dados = [

    { type: 'input', name: 'nome', message: 'Qual o seu nome? ' },
    { type: 'input', name: 'sobrenome', message: 'Qual o seu sobrenome?' },
    { type: 'input', name: 'sexo', message: 'Qual o seu sexo? ' },
    { type: 'input', name: 'idade', message: 'Qual a sua idade?' }
]

var option = [

    { type: 'input', name: 'option', message: 'Deseja registrar outra pessoa? ' }
];

function makePessoa(dados) {

    return inquirer.prompt(dados).then(answers => {
        var Pessoa = {
            _nome: answers['nome']
            , _sobrenome: answers['sobrenome']
            , _sexo: answers['sexo']
            , _idade: answers['idade']
        };
        console.log(Pessoa);
    })
};

function registroPessoa(dados) {
    let _option;

    makePessoa(dados).then

    inquirer.prompt(option).then(answers => {
        _option: answers['option']
        if (_option == 'sim') {
            return makePessoa(dados);
        }
    });
};

registroPessoa(dados);