function is_prime(num_prime){
    if (isNaN(num_prime)){return "Not a number!"}
    let i = 1;
    while(  i < num_prime) {
        if (num_prime % i === 0 && i !== 1){
            return false;
        }
        i++;
    }
    return true;
}

function prime_span(num_span){
    if (isNaN(num_span)){return "Not a number!"}
    let i = 1;
    while (i < num_span) {
        const num_h = is_prime(i);
        i++;
    }
}

const num_interval = 10_000;
let time_start = performance.now();
prime_span(num_interval);
const time_total = performance.now() - time_start;
console.log("The run time with ", num_interval, " params:");
console.log("in ms: " , time_total, "ms");
console.log("in seconds: ", time_total/1000, "s");
