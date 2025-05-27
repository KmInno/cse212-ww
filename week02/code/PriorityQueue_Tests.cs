using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priorities, then dequeue all.
    // Expected Result: Items are dequeued in order of highest to lowest priority.
    // Defect(s) Found: 
    public void TestPriorityQueue_DequeueOrder()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 2);

        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
        Assert.AreEqual("A", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue items with the same highest priority, then dequeue.
    // Expected Result: The item enqueued first with the highest priority is dequeued first (FIFO).
    // Defect(s) Found: 
    public void TestPriorityQueue_FIFOSamePriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 2);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 3);
        pq.Enqueue("D", 1);

        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
        Assert.AreEqual("A", pq.Dequeue());
        Assert.AreEqual("D", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: Exception is thrown.
    // Defect(s) Found: 
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPriorityQueue_EmptyDequeue()
    {
        var pq = new PriorityQueue();
        pq.Dequeue();
    }

    // Add more test cases as needed below.
}