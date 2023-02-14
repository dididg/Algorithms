// Problem taken from https://www.hackerrank.com/challenges/alien-username/problem
function processData(input) {
    const split = input.split('\n');
    const n = split[0];
    for(let i = 1; i <= n; i++) {
        const username = split[i];
        const isValid = processUserName(username);
        if (isValid) { console.log("VALID"); }
        else { console.log("INVALID"); }
    }
} 

function processUserName(username) {
    const regex = /^[_\.]\d+[A-Za-z]*_?$/;
    return regex.test(username);
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
