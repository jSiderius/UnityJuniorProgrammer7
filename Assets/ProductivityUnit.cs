using UnityEngine;

public class ProductivityUnit : Unit
{

    private ResourcePile m_CurrentPile = null;
    public float productivityMultiplier = 2.0f;

    protected override void BuildingInRange()
    {
        if (m_CurrentPile != null) { return; }

        ResourcePile pile = m_Target as ResourcePile;
        if (pile == null) { return; }

        m_CurrentPile = pile;
        pile.ProductionSpeed *= productivityMultiplier;
    }

    void ResetProductivity()
    {
        if (m_CurrentPile == null) { return; }

        m_CurrentPile.ProductionSpeed /= productivityMultiplier;
        m_CurrentPile = null;
    }

    public override void GoTo(Building target)
    {
        ResetProductivity();
        base.GoTo(target);
    }

    public override void GoTo(Vector3 position)
    {
        ResetProductivity();
        base.GoTo(position);
    }

}
