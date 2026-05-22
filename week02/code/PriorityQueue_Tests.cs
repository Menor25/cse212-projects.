using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a priority queue and add the following items: Bob (2), Tim (6), Sue (6), George (3). Dequeue all items until the queue is empty. 
    // Expected Result: Tim, Sue, George, Bob (Tim and Sue have the same priority but Tim was added first so he should follow FIFO rules and be retunred first).
    // Defect(s) Found: Highest priority item removed first, but if there are multiple items with the same priority, the one that was added last is removed first (FIFO). 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 6);
        priorityQueue.Enqueue("Sue", 6);
        priorityQueue.Enqueue("George", 3);

        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());
        Assert.AreEqual("George", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Create a priority queue and call Dequeue on it without adding any items to it first. 
    // Expected Result: An InvalidOperationException is thrown with the message "The queue is empty.
    // Defect(s) Found: An InvalidOperationException is thrown but with the wrong message. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        var except = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
        Assert.AreEqual("The queue is empty.", except.Message);
    }

    // Add more test cases as needed below.
}