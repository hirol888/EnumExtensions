using System;

namespace TestAndExamples
{
  public enum StatusEnum
  {
    [StatusEnumMetadata(Code = "200",
      Description =
        "OK indicates that the request succeeded and that the requested information is in the response. This is the most common status code to receive.",
      Color = "#69f0ae", Order = 1)]
    OK,

    [StatusEnumMetadata(Code = "201",
      Description = "Accepted indicates that the request has been accepted for further processing.", Color = "#00e676",
      Order = 3)]
    Accepted,

    [StatusEnumMetadata(Code = "300",
      Description =
        "Ambiguous indicates that the requested information has multiple representations. The default action is to treat this status as a redirect and follow the contents of the Location header associated with this response. Ambiguous is a synonym for MultipleChoices.",
      Color = "#00c853", Order = 2)]
    Ambiguous,

    [StatusEnumMetadata(Code = "502",
      Description =
        "BadGateway indicates that an intermediate proxy server received a bad response from another proxy or the origin server.",
      Order = 5)]
    BadGateway,

    [StatusEnumMetadata(Code = "400",
      Description =
        "BadRequest indicates that the request could not be understood by the server. BadRequest is sent when no other error is applicable, or if the exact error is unknown or does not have its own error code.",
      Color = "#7c27b0")]
    BadRequest
  }

  public class StatusEnumMetadata : Attribute
  {
    public string Code { get; set; }
    public string Description { get; set; }
    public string Color { get; set; }
    public int Order { get; set; }
  }
}