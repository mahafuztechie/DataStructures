// See https://aka.ms/new-console-template for more information
using DataStructures;

//CustomLinkedList customLinkedList = new CustomLinkedList();
//customLinkedList.AddLast(56);
//customLinkedList.AddLast(30);
//customLinkedList.AddLast(76);
//Console.WriteLine("nodes inserted");
//customLinkedList.DisplayLinkedList();

//customLinkedList.AddFirst(70);
//customLinkedList.AddFirst(30);
//customLinkedList.AddFirst(56);
//customLinkedList.DisplayLinkedList();
CustomLinkedList customLinkedList = new CustomLinkedList();
customLinkedList.Append(56);
customLinkedList.Append(70);
customLinkedList.Append(65);
customLinkedList.Append(90);
customLinkedList.DisplayLinkedList();
customLinkedList.InsertAtPosition(3, 30);
customLinkedList.DisplayLinkedList();
customLinkedList.DeleteFirst();
customLinkedList.DisplayLinkedList();
customLinkedList.DeleteLast();
customLinkedList.DisplayLinkedList();
customLinkedList.SearchNode(30);
customLinkedList.InsertAfter(15, 30);
customLinkedList.DisplayLinkedList();
customLinkedList.Size();

