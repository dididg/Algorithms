function processData(input) {
    let inputs = input.split('\n');
    //Enter your code here
    const n = Number.parseInt(inputs[0])
    console.error("sentence number: " + n)
    const sentences = inputs.slice(1, n+1)
    console.error("sentences: " + sentences)
    const q = inputs[n+1];
    console.error("query number: " + q);
    for(let i = 0; i < q; i++){ 
        console.error("iteration: " + (n+2+i));
        console.error("query: " + inputs[n+2+i])
        console.log(processSentences(inputs[n+2+i], sentences));
    }
} 
function processSentences(query, sentences) {
    let number = 0;
    sentences.forEach(function(sentence) {
        let temp = processSentence(query, sentence);
        console.error("Match number for " + sentence + " : " + temp);
        number += temp;
    });
    return number;
}

function processSentence(query, sentence) {
    const regex = new RegExp(`[\\w_]${query}[\\w_]`, 'g');
    console.error("Regex: " + regex)
    let matches = sentence.matchAll(regex)
    let number = 0;
    for (const match of matches) {
        console.error("Match for " + sentence + " : " + match)
        number++;
    }
    return number;
}

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
