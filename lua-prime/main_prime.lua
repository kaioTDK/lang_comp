function is_prime(number)
    for i = 2, number -1, 1 do
        if number % i == 0 then
            return false
        end
    end
    return true
end

function is_prime_range(number)
    for i = 1, number, 1 do
        if is_prime(i) then
            print(i," is prime!")
        end

    end
    
end

-- print(is_prime(17),"\n")
is_prime_range(10000)