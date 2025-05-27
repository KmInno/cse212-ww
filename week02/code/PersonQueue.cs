/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private List<Person> _queue = new List<Person>();

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person)
    {
        _queue.Add(person); // Add to the back
    }

    public Person Dequeue()
    {
        if (_queue.Count == 0)
            throw new InvalidOperationException("Queue is empty.");

        var person = _queue[0]; // Remove from the front
        _queue.RemoveAt(0);
        return person;
    }

    public int Length => _queue.Count;

    public bool IsEmpty() => _queue.Count == 0;

    public override string ToString()
    {
        return string.Join(", ", _queue.Select(p => p.Name));
    }
}