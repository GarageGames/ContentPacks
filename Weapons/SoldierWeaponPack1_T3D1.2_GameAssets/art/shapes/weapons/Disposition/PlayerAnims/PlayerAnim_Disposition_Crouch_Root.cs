singleton TSShapeConstructor(PlayerAnim_Disposition_Crouch_RootDAE)
{
   baseShape = "./PlayerAnim_Disposition_Crouch_Root.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Crouch_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Root", "280", "339");
}
