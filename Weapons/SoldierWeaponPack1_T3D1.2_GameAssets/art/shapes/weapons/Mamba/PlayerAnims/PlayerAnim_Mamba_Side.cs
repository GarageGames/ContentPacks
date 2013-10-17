singleton TSShapeConstructor(PlayerAnim_Mamba_SideDAE)
{
   baseShape = "./PlayerAnim_Mamba_Side.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Side", "200", "219");
}
