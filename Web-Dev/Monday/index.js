function handleSubmit(event) {

    event.preventDefault();
    const text = event.target.userSubmission.value.trim();
    switch(text.toLowerCase()) {
        case "yes":
            window.alert("Case Saved!")
            break;
        case "No":
            window.alert("Are you sure?")
            break;
        default:
            window.alert("No answer Given, try again!")
    }
}

function whileLoop() {
    let i = 0;
    let results = "";

    while (i < 100) {
        sum = i + i;
        results += `Iteration ${i}: ${sum}<br>`;
        i++
    }

    document.getElementById("result").innerHTML = results;
}

function forLoop() {
    let num = 0;
    let resultHtml = "";

    for(let i = 0; i < 100; i++) {
        if (i % 2 == 1) {
            num = i;
            resultHtml += `${num}<br>`; 
        }

        document.getElementById("forResult").innerHTML = resultHtml;
    }
}

function multiplicationTable(maxRows, maxColumns) {
    let table = "<div style='font-family: monospace;'>"; 

    for (let row = 1; row < maxRows; row++) {
        table += "<div>"; 

        for (let col = 1; col < maxColumns; col++) {
            let res = col * row;

            if (res < 10) {
                table += "0";
            }

            table += res + "|"; 
        }

        table += "</div>"; 
    }

    table += "</div>"; 

    document.getElementById("table").innerHTML = table;
}

function generateTable() {
    const rows = parseInt(document.getElementById("rows").value);
    const columns = parseInt(document.getElementById("columns").value);

    multiplicationTable(rows, columns);
}

function getNames(nameArray, ageArray) {

    const names = ["Alice", "Bob", "Charlie", "Diana"]; 

    const ages = [20, 21, 22, 23]; 

    for (let i = 0; i < names.length; i++) {
        console.log(`${names[i]} is ${ages[i]} years old`);
    }
}