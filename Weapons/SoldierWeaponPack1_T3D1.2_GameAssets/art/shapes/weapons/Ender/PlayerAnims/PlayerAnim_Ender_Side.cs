singleton TSShapeConstructor(PlayerAnim_Ender_SideDAE)
{
   baseShape = "./PlayerAnim_Ender_Side.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Side", "190", "209");
}
