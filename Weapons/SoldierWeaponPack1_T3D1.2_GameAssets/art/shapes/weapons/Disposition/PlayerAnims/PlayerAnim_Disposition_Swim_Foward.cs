singleton TSShapeConstructor(PlayerAnim_Disposition_Swim_FowardDAE)
{
   baseShape = "./PlayerAnim_Disposition_Swim_Foward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Swim_FowardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Foward", "1300", "1359");
}
