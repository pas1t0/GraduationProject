namespace WinFormsApplication.Singletons.Impl
{
    public class EditContext
    {
        private readonly List<EditBindings> _editBindings;

        public EditContext()
        {
            _editBindings = new();
        }

        public void Create(Control control, Label label, Func<bool> predicate)
        {
            _editBindings.Add(new()
            {
                Control = control,
                Label = label,
                Predicate = predicate,
            });

            control.TextChanged += (s, e) => SetDefault(control, label);
        }

        public bool Verify()
        {
            var result = true;

            foreach (var validation in _editBindings)
            {
                if (Verify(validation.Predicate, validation.Control, validation.Label) == false)
                {
                    result = false;
                }
            }

            return result;
        }

        private void SetAsCorrect(Control control, Label label)
        {
            control.ForeColor = Color.Red;

            label.ForeColor = Color.Red;
        }

        private void SetAsIncorrect(Control control, Label label)
        {
            control.ForeColor = Color.Green;

            label.ForeColor = Color.Green;
        }

        private bool Verify(Func<bool> condition, Control control, Label label)
        {
            var result = condition();

            if (result)
            {
                SetAsIncorrect(control, label);
            }
            else
            {
                SetAsCorrect(control, label);
            }

            return result;
        }

        private void SetDefault(Control control, Label label)
        {
            control.ForeColor = Color.Black;

            label.ForeColor = Color.Black;
        }

        public class EditBindings
        {
            public Control Control { get; set; }

            public Label Label { get; set; }

            public Func<bool> Predicate { get; set; }
        }
    }
}
