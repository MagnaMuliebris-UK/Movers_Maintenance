using Movers_Maintenance_Subsystem;

namespace NeaterOperations
{
    /// <summary>
    /// FastCall as a whole is just the faster and neater way to make "things" happen - the hub of Validation checks or action querying 
    /// <para>It is meant to clean up the front end slightly and reduce the overall redundant code in a Form by taking it to here.</para>
    /// <para>It also uses a lot of generic classes.</para>
    /// <para>All Methods here are static, thus - it is made as a struct.</para>
    /// </summary>  
    public struct FC
    {
        /// <summary>
        /// Generates a MessageBox, which prompts the user to press either a Yes or No.
        /// </para>Returns true on yes, false on any other result. </para> 
        /// </summary>
        /// <param name="Message">The message displayed in the MessageBox.</param>
        /// <param name="Title">The title shown at the top of the MessageBox.</param>
        /// <returns>Returns a boolean value based off of what button the User selects in the MessageBox.</returns>
        public static bool QueryAction(string Message, string Title)
        {
            if (OverarchingSettings.QueryActionIsEnabled)
            {
                DialogResult dialogResult = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        #region Generic Methods

        /// <summary>
        /// Makes a Control Object invisible, and removes interactibility.
        /// </summary>
        /// <typeparam name="Type"> A given Control Type.</typeparam>
        /// <param name="obj"> A given Control Object.</param>
        public static void Disable<Type>(Type obj) where Type : Control
        {
            obj.Enabled = false;
            obj.Visible = false;
        }

        /// <summary>
        /// Makes a Control Object visible and adds interactibility.
        /// </summary>
        /// <typeparam name="Type"> A given Control Type</typeparam>
        /// <param name="obj"> A given Control Object</param>
        public static void Enable<Type>(Type obj) where Type : Control
        {
            obj.Enabled = true;
            obj.Visible = true;
        }
        /// <summary>
        /// Takes many Control Objects, makes all of them visible and interactible.
        /// </summary>
        /// <typeparam name="Type">A given Control Type</typeparam>
        /// <param name="obj">A given list of Control Objects</param>
        public static void EnableEnMass<Type>(List<Type> obj) where Type : Control
        {
            foreach (Type type in obj)
            {
                type.Enabled = true;
                type.Visible = true;
            }
        }
        /// <summary>
        /// Takes many Control Objects, makes all of them invisible, and removes interactibility.
        /// </summary>
        /// <typeparam name="Type">A given Control Type</typeparam>
        /// <param name="obj">A given list of Control Object</param>
        public static void DisableEnMass<Type>(List<Type> obj) where Type : Control
        {
            foreach (Type type in obj)
            {
                type.Enabled = false;
                type.Visible = false;
            }
        }
        /// <summary>
        /// Makes any specified type of Form object stop using any resources and removes the traces of it from the thread
        /// <para>a slightly more 'extreme' version of the typical Form.Close </para>
        /// <para>it also allows for a Form object to be empty - in the event that the form hadn't been opened prior.</para>
        /// </summary>
        /// <typeparam name="Type"> A given Form Type.</typeparam>
        /// <param name="form"> A given Form.</param>
        public static void Remove<Type>(Type form) where Type : Form
        {
            if (form != null)
            {
                form.Close();
                form.Dispose();
            }
            else
            {
                //do nothing - form does not exist
                //This is here as a convenient place for breakpoints.
            }
        }
        /// <summary>
        /// Makes many Form objects stop using any resources and remove the traces of them from the thread
        /// <para>a slightly more 'extreme' version  of the typical Form.Close </para>
        /// <para>Also handles a null instance of a form automatically in the event a form was not open.</para>
        /// </summary>
        /// <typeparam name="Type">A given Form Type</typeparam>
        /// <param name="forms">A given list of Forms.</param>
        public static void RemoveEnMass<Type>(List<Type> forms) where Type : Form
        {
            foreach (Type type in forms)
            {
                if (type != null)
                {
                    type.Close();
                    type.Dispose();
                }
                else
                {
                    //do nothing - form does not exist
                    //This is here as a convenient place for breakpoints.
                }
            }
        }/// <summary>
         /// Makes any specified type of Form object stop using any resources and removes the traces of it from the thread
         /// <para>a slightly more 'extreme' version of the typical Form.Close </para>
         /// <para>it also allows for a Form object to be empty - in the event that the form hadn't been opened prior.</para>
         /// </summary>
         /// <typeparam name="Type"> A given Form Type.</typeparam>
         /// <param name="form"> A given Form.</param>
        public static void RemoveChildTrace<Type, Container>(Type form, Container container) where Type : Form where Container : ContainerControl
        {
            if (form != null)
            {
                container.Controls.Remove(form);
                form.Close();
                form.Dispose();
            }
            else
            {
                //do nothing - form does not exist
                //This is here as a convenient place for breakpoints.
            }
        }
        /// <summary>
        /// Makes many Form objects stop using any resources and remove the traces of them from the thread
        /// <para>a slightly more 'extreme' version  of the typical Form.Close </para>
        /// <para>Also handles a null instance of a form automatically in the event a form was not open.</para>
        /// </summary>
        /// <typeparam name="Type">A given Form Type</typeparam>
        /// <param name="forms">A given list of Forms.</param>
        public static void RemoveChildTraceEnMass<Type, Container>(List<Type> forms, Container container) where Type : Form where Container : ContainerControl
        {
            foreach (Type type in forms)
            {
                if (type != null)
                {
                    container.Controls.Remove(type);
                    type.Close();
                    type.Dispose();
                }
                else
                {
                    //do nothing - form does not exist
                    //This is here as a convenient place for breakpoints.
                }
            }
        }

        /// <summary>
        /// Makes one form the parent of another form. It then opens the child form.
        /// </summary>
        /// <typeparam name="Parent"> Represents any type of form, this is the type the Parent Form is under.</typeparam>
        /// <typeparam name="Child"> Represents any type of form, this is the type the Child Form is under.</typeparam>
        /// <param name="FormP"> Represents the Parent Form.</param>
        /// <param name="FormC"> Represents the Child Form.</param>
        public static void EstablishParent<Parent, Child>(Parent FormParent, Child FormChild, Panel P) where Child : Form where Parent : Form
        {
            //ONLY because I HATE the idea of using something like this - I MUCH prefer a referencable method - like this FC Method
            FormChild.MdiParent = FormParent;
            FormChild.TopLevel = false;
            Size pSize = P.ClientSize;
            FormChild.Size = pSize;
            P.Controls.Add(FormChild);
        }
        #endregion Generic Methods
        #region Validation that lasts globally
        /// <summary>
        /// Validation used to ensure something follows the NVarChar(50) format for SQL.
        /// </summary>
        /// <param name="s">Entered string to be checked</param>
        /// <param name="cap">Whatever the nvarchar cap is - or any othersuch feature in the event this is also handy.</param>
        /// <returns>Returns true if the string count exceeds the cap.</returns>
        public static bool NVarCharExceeds(string s, int cap)
        {
            char[] ca = s.ToCharArray();
            if(ca.Count()>cap)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Checks each letter systematically to ensure the string only has letters, and no special characters or numbers.
        /// </summary>
        /// <param name="s">String provided to be checked.</param>
        /// <returns>False on number or special character detection, true </returns>
        public static bool OnlyLetters(string s)
        {
            char[] ca = s.ToCharArray();
            bool trip = false;
            foreach(char c in ca)
            {
                if(!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Checks a String - uses OnlyLetters and NVarChar(50) as base in this case - modify for other reasons.
        /// </summary>
        /// <param name="s">The string being checked.</param>
        /// <param name="cap">The cap for the length check (NVarCharExceeds).</param>
        /// <returns>Returns a 0 if there are numbers or special characters, 1 if there are both special characters or numbers, and the number of characters exceeds the given cap, 2 if the string passes both checks, and 3 if the number of characters exceeds the cap.</returns>
        public static int MultiValidationSTRING(string s, int? cap)
        {
            int counter = 0;
            int ncap = (int)cap;
            if (!cap.HasValue || ncap == 0 || cap == null)
            {
                //Default to
                ncap = (int)50;
            }
            bool Val1 = false;
            bool Val2 = false;
            Val1 = NVarCharExceeds(s, ncap); //want false
            Val2 = OnlyLetters(s); //want true
            if (Val1 && Val2)
            {
                counter = 3;
            }
            else if (Val1) 
            { 
                counter = 1; 
            }
            else if (Val2) 
            { 
                counter = 2; //correct output
            }
            return counter;
        }
        #endregion Validation that lasts globally
    }
}