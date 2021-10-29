const resultado = fizzBuzz('9');
console.log(resultado);




function fizzBuzz(num) {

    if(typeof num == "number") {
        
        if(num % 5 == 0 && num % 3 == 0) {
            return 'FizzBuzz';
        }else if (num % 5 == 0) {
            return 'Buzz';
        }else if (num % 3 == 0) {
            return 'Fizz';
        }else {
            return num;
        }       
    }
    else{
        return 'Não é um numero';
    }
}
