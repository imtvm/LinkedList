/* 
 * Author: Tyler Vergis-Mayo
 * Github: www.github.com/imtvm
 * Date: January 16th 2019
 * Description: This is a class that defines a linked list and its needed functions.
 */

using System;
namespace Application
{
    public class LinkedList<T>
    {
        private class Node<T> {
            private Node next;
            private T value;

            public Node(Node<T> next, T value) {
                this.next = next;
                this.value = value;
            }

            public Node<T> getNext() { return next; }
            public T getValue() { return value; }

            public void setNext(Node<T> next) { this.next = next; }
            public void setValue(T value) { this.value = value; }
        }

        private Node<T> head = null, tail = null;
        private int size = 0;

        public LinkedList() {}

        public bool isEmpty() { return size == 0; }

        public int size() { return size; }

        public T first() {
            if (isEmpty()) { return null; }

            return head.getValue();
        }

        public T last() {
            if (isEmpty()) { return null; }

            return tail.getValue();
        }

        public insertFirst(T value) {
            head = new Node<T>(t, head);
            if (size == 0) {
                tail == head;
            }
            size++;
        }

        public insertAtTail(T value) {
            Node<T> newNode = new Node<T>(value, null);
            if (size == 0) {
                head == newNode;
            } else {
                tail.setNext(newNode);
            }
            tail = newNode;
            size++;
        }

        public removeAtHead() {
            if (isEmpty()) { return null; }
            T value = head.getValue();

            head = head.getNext();
            size--;

            if (size == 0){
                tail = null
            }

            return value;
        }
    }
}
