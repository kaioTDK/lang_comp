local function gen(lenght)
    local file = io.open("arrays1000.txt", "a+")
    if file ~= nil then
        file:write("Array of ", lenght, " = [")
        for i = 0, lenght - 1, 1  do
            local num = math.random(0, lenght - 1)
            if i < lenght - 1 then
                file:write(num,",")
    
            elseif i == lenght - 1 then
                file:write(num,"]\n")
            end
        end
        file:close()
    else
        print("Could not open file!")
    end
end

params = {10000,100000,1000000}

for index, value in ipairs(params) do
    gen(value)
end