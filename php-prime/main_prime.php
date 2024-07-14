<?php
function is_prime($num): bool {
    for ($i = 2; $i < $num; $i++) {
        if ($num % $i === 0) {
        return false;
        };
    }
    return true;
};

function is_prime_span($num): bool {
    for ($i = 1; $i < $num; $i++) {
        $result = is_prime($i);
        if ($result) print("$i is prime!\n");
    };
    return true;
}

$time_start = microtime(true);
is_prime_span(10000);
$time_total = microtime(true) - $time_start;
$time_total_ms = $time_total / 1000;
$time_total_s = $time_total_ms / 1000;
print("$time_total\n");
print("$time_total_ms\n");
print("$time_total_s\n");