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

function testQuickSort(lenght) 

    local array= {}
    for i = 1, lenght, 1 do
        array[i] = math.random(1,lenght)
    end
    local start = os.clock()
    quick_sort(array,1,lenght)
    local endC = os.clock()
    local time_total = endC - start
    print(time_total*1000)
end

testQuickSort(10000)
testQuickSort(100000)
testQuickSort(1000000)
