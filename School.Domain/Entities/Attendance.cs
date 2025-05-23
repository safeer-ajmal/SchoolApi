﻿namespace School.Domain.Entities;
public class Attendance
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public bool IsPresent { get; set; }
    public Guid StudentId { get; set; }
    public Student Student { get; set; }
}