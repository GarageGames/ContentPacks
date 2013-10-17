singleton TSShapeConstructor(PlayerAnim_Disposition_LandDAE)
{
   baseShape = "./PlayerAnim_Disposition_Land.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_LandDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Land", "990", "1005");
}
