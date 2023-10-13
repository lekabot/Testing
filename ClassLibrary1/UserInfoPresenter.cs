namespace ClassLibrary1;

public class UserInfoPresenter
{
    private readonly IUserInfo _form;

    public UserInfoPresenter(IUserInfo form)
    {
        _form = form;
        _form.SaveAttempted += _form_SaveAttempted;
    }

    private void _form_SaveAttempted(object? sender, EventArgs e)
    {
        _form.ShowFormErrors = false;
        _form.ErrorMessage = null;

        if (string.IsNullOrEmpty(_form.FirstName))
            AppendErrorMessage("First Name cannot be empty");

        if (string.IsNullOrEmpty(_form.LastName))
            AppendErrorMessage("Last Name cannot be empty");

        if (string.IsNullOrEmpty(_form.Email))
            AppendErrorMessage("Email cannot be empty");
        else if (!_form.Email.Contains("@"))
            AppendErrorMessage("Email must contain @ symbol");

        if (string.IsNullOrEmpty(_form.PlaceOfResidence))
            AppendErrorMessage("Place of residence cannot be empty");

        if (string.IsNullOrEmpty(_form.Gender))
            AppendErrorMessage("Gender cannot be empty");

        if (string.IsNullOrEmpty(_form.Phone))
            AppendErrorMessage("Phone cannot be empty");
    }

    private void AppendErrorMessage(string message)
    {
        _form.ShowFormErrors = true;
        _form.ErrorMessage += $"\n{message}";
    }
}