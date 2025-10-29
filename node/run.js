console.log("Current system date and time:");
const now = new Date();
function pad(num) {
    return (num < 10 ? '0' : '') + num;
}
const formatted = now.getFullYear() + "-" +
    pad(now.getMonth() + 1) + "-" +
    pad(now.getDate()) + " " +
    pad(now.getHours()) + ":" +
    pad(now.getMinutes()) + ":" +
    pad(now.getSeconds());
console.log(formatted);
