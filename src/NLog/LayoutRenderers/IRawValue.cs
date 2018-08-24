namespace NLog.LayoutRenderers
{
    /// <summary>
    /// Get the Raw, unformatted and unstrinyfied, value
    /// </summary>
    internal interface IRawValue
    {
        /// <summary>
        /// Get the raw value
        /// </summary>
        /// <param name="logEvent"></param>
        /// <returns>null if not possible or unknown</returns>
        object GetRawValue(LogEventInfo logEvent);

    }
}
