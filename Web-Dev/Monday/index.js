function handleSubmit(event) {

    event.preventDefault();
    const text = event.target.userSubmission.value.trim();
    switch(text.toLowerCase()) {
        case "yes":
            window.alert("Case Saved!")
            break;
        case "No":
            window.alert("Are you sure?")
            break;
        default:
            window.alert("No answer Given, try again!")
    }
}