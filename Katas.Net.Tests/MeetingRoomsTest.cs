namespace Katas.Net.Tests;

public class MeetingRoomsTest
{
    [TestCase(1, new [] { 10, 15 }, new [] {20, 25}, new [] { 30, 35})]
    [TestCase(2, new [] { 10, 20 }, new [] {15, 25}, new [] { 24, 30})]
    [TestCase(1, new [] { 10, 20 }, new [] { 20, 30})]
    [TestCase(3, new [] { 10, 21 }, new [] {15, 30}, new [] { 20, 30})]
    public void FindMinimumRequiredMeetingRooms(int expectedOutput, params int[][] timeIntervals)
    {
        var output = MeetingRooms.FindMinimumRequiredRooms(timeIntervals.Select(ti => (ti[0], ti[1])).ToArray());

        Assert.That(output, Is.EqualTo(expectedOutput));
    }
}