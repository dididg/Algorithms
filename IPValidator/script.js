function processData(input) {
    const split = input.split('\n');
    const n = split[0];
    for (let i = 1; i <= n; i++) {
        console.log(processText(split[i]));
    }
} 

function processText(text) {
    const innerIPv4 = "(25[0-5]|2[0-4]\\d|1?\\d?\\d)"
    const iPv4 = new RegExp(`\\b${innerIPv4}(\\.${innerIPv4}){3}\\b`);
    console.error(`iPv4 regex: ${iPv4}`);
    const innerIPv6 = "[0-9a-f]{1,4}";
    const iPv6 = new RegExp(`\\b${innerIPv6}(:${innerIPv6}){7}\\b`);
    console.error(`iPv6 regex: ${iPv6}`);
    if (iPv4.test(text)) { return "IPv4"; }
    if (iPv6.test(text)) { return "IPv6"; }
    return "Neither";
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
