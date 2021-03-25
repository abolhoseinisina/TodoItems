const uri = 'api/Todo';
let todos = [];

function getItems() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}

function getPlaces() {
    fetch('api/Place')
        .then(response => response.json())
        .then(data => {
            data.forEach(item => {
                var e = document.createElement('option');
                e.value = item.id;
                e.innerHTML = item.title;
                document.getElementById('add-location').appendChild(e);
                var ce = e.cloneNode(true);
                document.getElementById('edit-location').appendChild(ce);
            })
        })
        .catch(error => console.error('Unable to get items.', error));
}

function addItem() {
    const title = document.getElementById('add-title').value.trim();
    const desc = document.getElementById('add-description').value.trim();
    const dueDate = document.getElementById('add-due-date').value.trim();
    const location = document.getElementById('add-location').value.trim();

    const item = {
        isComplete: false,
        title: title,
        description: desc,
        dueTime: dueDate,
        createTime: (new Date()).toISOString(),
        placeid: location
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(response => response.json())
        .then(() => {
            getItems();
            addNameTextbox.value = '';
        })
        .catch(error => {
            getItems();
            console.error('Unable to add item.', error)
        });
}

function deleteItem(id) {
    const item = {
        id: id
    };
    fetch(uri, {
        method: 'DELETE',
        body: JSON.stringify(item),
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to delete item.', error));
}

function displayEditForm(id) {
    const item = todos.find(item => item.id === id);
    document.getElementById('edit-id').value = item.id;
    document.getElementById('edit-isDone').checked = item.isDone;

    document.getElementById('edit-title').value = item.title;
    document.getElementById('edit-description').value = item.description;
    document.getElementById('edit-due-date').value = item.dueTime;
    document.getElementById('edit-location').value = item.placeId;

    document.getElementById('editForm').style.display = 'block';
}

function updateItem() {
    const itemId = document.getElementById('edit-id').value;
    const item = {
        id: parseInt(itemId, 10),
        isDone: document.getElementById('edit-isDone').checked,
        title: document.getElementById('edit-title').value.trim(),
        description: document.getElementById('edit-description').value.trim(),
        dueTime: document.getElementById('edit-due-date').value.trim(),
        placeid: document.getElementById('edit-location').value.trim()
    };

    fetch(uri, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to update item.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayCount(itemCount) {
    const name = (itemCount === 1) ? 'to-do' : 'to-dos';
    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

function _displayItems(data) {
    const tBody = document.getElementById('todos');
    tBody.innerHTML = '';

    _displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(item => {
        let isCompleteCheckbox = document.createElement('input');
        isCompleteCheckbox.type = 'checkbox';
        isCompleteCheckbox.disabled = true;
        isCompleteCheckbox.checked = item.isDone;

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${item.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteItem(${item.id})`);

        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        td1.appendChild(isCompleteCheckbox);

        let td2 = tr.insertCell(1);
        let textNode1 = document.createTextNode(item.title);
        td2.appendChild(textNode1);

        let td3 = tr.insertCell(2);
        let textNode2 = document.createTextNode(item.description);
        td3.appendChild(textNode2);

        let td4 = tr.insertCell(3);
        let textNode3 = document.createTextNode(item.dueTime);
        td4.appendChild(textNode3);

        let td5 = tr.insertCell(4);
        let textNode4 = document.createTextNode(item.place.title);
        td5.appendChild(textNode4);

        let td6 = tr.insertCell(5);
        td6.appendChild(editButton);

        let td7 = tr.insertCell(6);
        td7.appendChild(deleteButton);
    });

    todos = data;
}