namespace WorkflowApp;
internal static class Constants
{
    public const string DAPR_INVENTORY_COMPONENT = "inventory";
    public const string DAPR_PUBSUB_COMPONENT = "shippingpubsub";
    public const string DAPR_PUBSUB_REGISTRATION_TOPIC = "shipment-registration-events";
    public const string SHIPMENT_REGISTERED_EVENT = "shipment-registered-event";
}