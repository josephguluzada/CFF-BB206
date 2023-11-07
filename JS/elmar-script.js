let todoInput = document.getElementById("todoInput");
let addBtn = document.getElementById("addBtn");
let taskList = document.getElementById("taskList");

let createLi = function () {
    if (todoInput.value != "") {
        // Create li elemet
        let li = document.createElement("li");
        let deleteBtn = document.createElement("button");
        deleteBtn.innerText = "delete"

        deleteBtn.addEventListener("click", function () {
            // li.remove();
            // li.classList.toggle("li-red")
        })

        // Add value into li element
        li.innerText = todoInput.value;
        // li.innerHTML = todoInput.value
        li.appendChild(deleteBtn)

        // Append li into ul
        taskList.appendChild(li);
        // Clear input value (reset input value)
        todoInput.value = "";
    }
    else {
        alert("Input bosh ola bilmez!")
    }
};

addBtn.addEventListener("click", createLi)