local function partition(array, start, end_arr)
    local pivot = array[end_arr]
    local index = start - 1
    for j = start, end_arr - 1, 1 do
        if array[j] < pivot then
            index = index + 1
            local temp = array[index]
            array[index] = array[j]
            array[j] = temp
        end
    end
    index = index + 1
            local temp = array[index]
            array[index] = array[end_arr]
            array[end_arr] = temp

    return index
end

function quick_sort(array, start, end_arr)
    if end_arr <= start then
        return
    end
    local pivot = partition(array, start, end_arr)
    quick_sort(array, start, pivot - 1)
    quick_sort(array, pivot + 1, end_arr)


end

arr = {}
arr[1] = 6
arr[2] = 10
arr[3] = 14
arr[4] = 5
arr[5] = 11
arr[6] = 13
arr[7] = 1
arr[8] = 12
arr[9] = 2
arr[10] = 4
arr[11] = 7
arr[12] = 8
arr[13] = 9
arr[14] = 3

for index, value in ipairs(arr) do
    print(index,value)    
end
 
quick_sort(arr,1,14)
for index, value in ipairs(arr) do
    print(index,value)    
end
