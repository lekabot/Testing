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
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nFirst Name cannot be empty";
        }

        if (string.IsNullOrEmpty(_form.Email))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nEmail cannot be empty";
        }

        if (!string.IsNullOrEmpty(_form.Email) && !_form.Email.Contains("@"))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nEmail must contain @ symbol";
        }

        if (string.IsNullOrEmpty(_form.LastName))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nLast Name cannot be empty";
        }

        if (string.IsNullOrEmpty(_form.Phone))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nPhone cannot be empty";
        }
        if (string.IsNullOrEmpty(_form.Gender))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nGender cannot be empty";
        }
        if (string.IsNullOrEmpty(_form.PlaceOfResidence))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nPlace of residence cannot be empty";
        }
    }
}