namespace REST.Domain;

public record Product
(
    int id,
    string title,
    string description,
    double price
);