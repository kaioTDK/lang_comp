function is_prime(num_prime){
    if (isNaN(num_prime)){return "Not a number!"}
    for(let i = 1; i < num_prime; i++) {
        if (num_prime % i === 0 && i !== 1){
            return false;
        }
    }
    return true;
}

function prime_span(num_span){

    for (let i = 1; i < num_span; i++) {
        const num_h = is_prime(i);
        if (num_h == true){
            console.log(i + " is prime!");
        }
    }
}

//console.log(is_prime(13));
const num_interval = 10_0000;
let time_start = Date.now();
prime_span(num_interval);
let time_end = Date.now();
const time_total = time_end - time_start;
console.log("The run time with ", num_interval, " params:");
console.log("in ms: " , time_total, "ms");
console.log("in seconds: ", time_total/1000, "s");
