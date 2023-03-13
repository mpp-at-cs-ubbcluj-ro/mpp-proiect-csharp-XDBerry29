using System;

public interface Repository<ID, entityType> where entityType : Entitate<ID>
{
    void adauga(entityType entity);
    void sterge(entityType entity);
    entityType cautaId(String id);
    List<entityType> getAll();
    void update(entityType entitate, entityType nouaEntitate);
}