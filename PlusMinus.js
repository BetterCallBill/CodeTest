function plusMinus(arr) {
    let counter = new Array(3).fill(0);
    for(let value of arr) {
        if(value > 0)
            counter[0]++;
        else if(value < 0)
            counter[1]++;
        else
            counter[2]++;
    }
    counter.map((value) => console.log((value / arr.length).toFixed(6)));
}