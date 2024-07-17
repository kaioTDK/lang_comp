function prime_span(num_span){
    isPrime = true;
    for (let i = 1; i < num_span; i++) {
        isPrime = true;
        for(let ii = 2; ii < i; ii++) {
            if (i % ii === 0){
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {console.log(i)}
    }
}

//console.log(is_prime(13));
const num_interval = 10_000;
let time_start = performance.now();
prime_span(num_interval);
time_total = performance.now() - time_start;
console.log("The run time with ", num_interval, " params:");
console.log("in ms: " , time_total, "ms");
console.log("in seconds: ", time_total/1000, "s");

time_start = performance.now();
prime_span(num_interval);
time_total = performance.now() - time_start;
console.log("second run \nThe run time with ", num_interval, " params:");
console.log("in ms: " , time_total, "ms");
console.log("in seconds: ", time_total/1000, "s");
