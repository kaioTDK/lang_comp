local function is_prime(number)
    for i = 2, number - 1, 1 do
        if number % i == 0 then
            return false
        end
    end
    return true
end

local function is_prime_range(number)
    for i = 1, number, 1 do
        if is_prime(i) then
           -- print(i," is prime!")
        end

    end
    
end

local time_start = os.clock()
is_prime_range(10000)
local time_end = os.clock()
local time_total = time_end - time_start

print("Ran for ", time_total, " seconds")
print("Ran for ", time_total * 1000, " ms")