namespace Account.Application.DTOs;

public record SendEmailDto(string Recipient, string Subject, string Body);
