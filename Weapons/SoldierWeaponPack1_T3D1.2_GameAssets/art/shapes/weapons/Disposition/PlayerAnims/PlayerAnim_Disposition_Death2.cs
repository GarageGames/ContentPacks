singleton TSShapeConstructor(PlayerAnim_Disposition_Death2DAE)
{
   baseShape = "./PlayerAnim_Disposition_Death2.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Death2DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death2", "1100", "1140");
}
