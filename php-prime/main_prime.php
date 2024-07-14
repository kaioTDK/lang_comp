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
    };
    return true;
}

$time_start = microtime(true);
is_prime_span(100000);
$time_end = microtime(true);
$time_total = $time_end - $time_start;
$time_total_ms = $time_total * 1000;
print("$time_total\n");
print("$time_total_ms\n");