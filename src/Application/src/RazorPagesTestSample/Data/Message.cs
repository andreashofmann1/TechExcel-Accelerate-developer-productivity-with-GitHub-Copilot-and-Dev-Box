using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the message text.
        /// </summary>
        /// <value>
        /// The message text, limited to 250 characters.
        /// </value>
        /// <remarks>
        /// This property is required and must be a text string. 
        /// If the message exceeds 250 characters, an error will be thrown.
        /// </remarks>
        /// <exception cref="ValidationException">
        /// Thrown when the message exceeds 250 characters.
        /// </exception>
        [Required]
        [DataType(DataType.Text)]
        [StringLength(250, ErrorMessage = "There's a 250 character limit on messages. Please shorten your message.")]
        public string Text { get; set; }
    }
    #endregion
}
