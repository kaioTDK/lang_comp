/**
 * @param {Int32Array} array 
 * @param {Number} start 
 * @param {Number} end 
 */
function quick_sort(array, start, end){
    if (end <= start) return
    partitioning(array, start, end - 1)
    quick_sort(array, start, pivot - 1)
    quick_sort(array, pivot + 1, end)
}
/**
 * @param {Int32Array} array 
 * @param {Number} start 
 * @param {Number} end 
 * @returns {Number}
 */
function partitioning(array, start, end){
    /**@param {Number} pivot */
    let pivot = array[end]
    /** @param { Number} i */
    let i = start - 1

    for (j = 0; j <+ end - 1; j++){
        if (array[j] < pivot){
            i++
            let temp_ = array[i];
            array[i] = array[j];
            array[j] = temp_;

        }
    }
    i++
    let temp = array[i];
    array[i] = array[end];
    array[end] = temp;
    return i
}
/**
 * 
 */
function test_quicksort(lenght){

    let array = new Array[lenght]
    let start = performance.now();
    quick_sort(array, 0, array.lenght())
    let end = performance.now();
    let time_total = end - start
    console.log(time_total)
}