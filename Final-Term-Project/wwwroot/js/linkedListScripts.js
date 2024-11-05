// Hàm thêm node mới
function addNode() {
    const value = document.getElementById("node-value").value;
    if (value === "") return;

    fetch('/LinkedList/AddNode', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(parseInt(value))
    })
        .then(response => response.json())
        .then(data => displayList(data))
        .catch(error => console.error('Error:', error));
}

// Hàm xóa node đầu tiên
function deleteFirstNode() {
    fetch('/LinkedList/DeleteFirstNode', {
        method: 'POST'
    })
        .then(response => response.json())
        .then(data => displayList(data))
        .catch(error => console.error('Error:', error));
}

// Hàm xóa node cuối cùng
function deleteLastNode() {
    fetch('/LinkedList/DeleteLastNode', {
        method: 'POST'
    })
        .then(response => response.json())
        .then(data => displayList(data))
        .catch(error => console.error('Error:', error));
}

// Hàm hiển thị danh sách
// Hàm hiển thị danh sách
function displayList(list) {
    const listContainer = document.getElementById("linked-list");
    const statusContainer = document.getElementById("linked-list-status");

    listContainer.innerHTML = ""; // Xóa nội dung cũ

    if (list.length === 0) {
        statusContainer.innerText = "Danh sách hiện đang trống";
    } else {
        statusContainer.innerText = ""; // Xóa thông báo nếu danh sách có phần tử

        list.forEach(item => {
            const nodeElement = document.createElement("div");
            nodeElement.className = "node";
            nodeElement.innerText = item;
            listContainer.appendChild(nodeElement);
        });
    }

}
