function timeConversion(s) {
    // Write your code here
    let ultimosDois = s.substring(8);
    let horaCompleta = s.substring(0, 8);

    let vetor = horaCompleta.split(':');

    if (ultimosDois === 'PM') {
        if (vetor[0] !== '12') {
            vetor[0] = parseInt(vetor[0]) + 12;
        }
    } else {
        if (vetor[0] === '12')
            vetor[0] = '00';
    }

    return vetor.join(':');
}
