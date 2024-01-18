namespace backend.Models.DTOs;

public class ChangePasswordDTO
{
    public string OldPassword { get; set; } = string.Empty;
    public string NewPassword { get; set; } = string.Empty;
    public string NewPasswordConfirmation { get; set; } = string.Empty;
}