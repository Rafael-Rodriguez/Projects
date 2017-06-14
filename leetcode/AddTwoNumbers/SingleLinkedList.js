function Node(data) {
    this.data = data;
    this.next = null;
}

function SingleLinkedList() {
    this.length = 0;
    this.head = null;
}

SingleLinkedList.prototype.add = function(value)
{
    var node = new Node(value);
    var currentNode = this.head;

    if(!currentNode)
    {
        this.head = node;
        this.length++;
        return node;
    }

    while(currentNode.next)
    {
        currentNode = currentNode.next;
    }

    this.length++;

    return node;
}

