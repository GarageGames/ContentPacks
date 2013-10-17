singleton TSShapeConstructor(PlayerAnim_Disposition_SideDAE)
{
   baseShape = "./PlayerAnim_Disposition_Side.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Side", "180", "199");
}
