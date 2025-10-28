console.log("Current system date and time:");
const now = new Date();
const formatted = now.getFullYear() + "-" + 
    String(now.getMonth() + 1).padStart(2, '0') + "-" + 
    String(now.getDate()).padStart(2, '0') + " " + 
    String(now.getHours()).padStart(2, '0') + ":" + 
    String(now.getMinutes()).padStart(2, '0') + ":" + 
    String(now.getSeconds()).padStart(2, '0');
console.log(formatted);
